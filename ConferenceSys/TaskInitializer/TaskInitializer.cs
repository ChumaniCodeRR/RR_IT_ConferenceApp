using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace RhodesControl
{
    public partial class TaskInitializer : Form
    {
        int total, complete, originalHeight;

        List<InitializingTask> _tasks;
        List<InitializingTask> failed;

        #region Constructors

        public TaskInitializer()
        {
            InitializeComponent();
        }

        public TaskInitializer(List<InitializingTask> tasks)
        {
            InitializeComponent();
            
            dgvTask.AutoGenerateColumns = false;
            originalHeight = this.Height;
            _tasks = tasks;
        }

        #endregion

        #region Form Events

        private void TaskInitializer_Load(object sender, EventArgs e)
        {
            splitContainerInitializing.Panel2Collapsed = true;
            SetInitializerDetails();
            
            dgvTask.DataSource = _tasks;
            BeginInitializingTask(_tasks);
        }

        #endregion

        #region LinkLabel Events

        private void lkShowHideDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            splitContainerInitializing.Panel2Collapsed = !splitContainerInitializing.Panel2Collapsed;
            SetInitializerDetails();
        }

        #endregion

        #region Local Methods

        void SetInitializerDetails()
        {
            if (splitContainerInitializing.Panel2Collapsed)
            {
                lkShowHideDetails.Text = "Show Details";
                this.Size = new Size(290, 105);
            }
            else
            {
                lkShowHideDetails.Text = "Hide Details";
                this.Size = new Size(290, originalHeight);
            }
        }

        void BeginInitializingTask(List<InitializingTask> list)
        {
            failed = null;

            complete = 0;
            total = list.Count;

            list.ForEach(delegate(InitializingTask t)
            {
                IAsyncResult result = t.TargetMethod.BeginInvoke(EndInitializingTask, t);
                result.AsyncWaitHandle.WaitOne();
            });
        }

        void EndInitializingTask(IAsyncResult results)
        {
            InitializingTask t = (InitializingTask)results.AsyncState;
            try
            {
                complete++;
                t.TargetMethod.EndInvoke(results);
            }
            catch
            {
                if (failed == null)
                {
                    failed = new List<InitializingTask>();
                }
                failed.Add(t);
                
                //Block the calling thread until the current thread terminates
                Thread thread = Thread.CurrentThread;
                thread.Join();
            }

            //If all tasks have competed, check if all competed successfully.
            if (complete.Equals(total))
            {
                ValidateInitializingSuccess();
            }
        }

        void ValidateInitializingSuccess()
        {
            if (failed != null && failed.Count > 0)
            {
                string msg = "One or more tasks failed to initialize. Do you want to try?";
                DialogResult result = MessageBox.Show(msg, "Initializing", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result.Equals(DialogResult.Retry))
                {
                    BeginInitializingTask(failed);
                }
                else
                {
                    CloseTaskInitializer();
                }
            }
            else
            {
                CloseTaskInitializer();
            }
        }

        void CloseTaskInitializer()
        {
            //if (InvokeRequired)
            //{
            //    Invoke(new EventHandler(Close), this, new EventArgs());
            //}
            //else
            //{
            //    Close();
            //}
            TaskInitializeLoader.EndInitializer();
        }

        //void Close(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        #endregion
    }
}
