using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RhodesControl
{
    public class InitializingTask
    {

        public InitializingTask(string taskDescription, TaskInitializeLoader.TaskInitializeHandler target)
        {
            _taskDescription = taskDescription;
            _targetMethod = target;
        }

        string _taskDescription;

        public string TaskDescription
        {
            get { return _taskDescription; }
        }

        TaskInitializeLoader.TaskInitializeHandler _targetMethod;

        public TaskInitializeLoader.TaskInitializeHandler TargetMethod
        {
            get { return _targetMethod; }
        }
    }
}
