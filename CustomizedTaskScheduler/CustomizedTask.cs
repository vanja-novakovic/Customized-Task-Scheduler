using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectScheduler
{
    public class CustomizedTask : IComparable
    {
        private Task task;
        // private Action action;
        private Priority priority;
        public int Duration { get; private set; }
        public object[] resources;

        public CustomizedTask(Action action, Priority priority, int duration, object[] resources)
        {
            task = new Task(action);
            this.priority = priority;
            Duration = duration;
            this.resources = resources;
        }

        public Task GetTask()
        {
            return this.task;
        }

        public Priority GetPriority()
        {
            return this.priority;
        }

        public object[] GetResources()
        {
            return resources;
        }
     
        public int CompareTo(CustomizedTask task)
        {
            return 0; 
        }

        public int CompareTo(object obj)
        {
            return -1;
        }
    }

    public enum Priority 
    {
        High, Medium, Low
    }

}
