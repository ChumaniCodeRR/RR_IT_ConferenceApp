using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace RhodesControl
{
    public static class TaskInitializeLoader
    {
        static Thread initThread;
        public delegate void TaskInitializeHandler();
        private static List<InitializingTask> tasks = new List<InitializingTask>();

        public static void AddTask(string taskDescription, TaskInitializeHandler target)
        {
            tasks.Add(new InitializingTask(taskDescription, target));
        }

        public static void StartInitializer()
        {
            initThread = new Thread(new ParameterizedThreadStart(ShowTaskInitializer));
            initThread.Start(tasks);
            Thread.CurrentThread.Join();
        }

        static void ShowTaskInitializer(object tasks)
        {
            using (TaskInitializer taskInit = new TaskInitializer((List<InitializingTask>)tasks))
            {
                System.Windows.Forms.Application.Run(taskInit);
            }
        }

        public static void EndInitializer()
        {
            if (initThread != null)
            {
                initThread.Abort();
            }
        }
    }
}
