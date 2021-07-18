using System;
using System.Collections.Generic;

namespace ProjectScheduler
{
    public class CustomizedTaskScheduler
    {
        SortedDictionary<CustomizedTask, CustomizedTask> pendingTasks = new SortedDictionary<CustomizedTask, CustomizedTask>(new Comparator());
    
        public void AddTask(CustomizedTask task)
        {
            pendingTasks.Add(task, task);
        }

        public void printAll()
        {
            foreach(var task in pendingTasks)
                Console.WriteLine(task.Value.Duration);
        }
    }

    class Comparator : IComparer<CustomizedTask>
    {
        public int Compare(CustomizedTask x, CustomizedTask y)
        {
            if ((int)x.GetPriority() > (int)y.GetPriority())
                return 1;
            else if (x.Duration > y.Duration)
                return 1;
            return -1;
        }
    }
}
 