using System;
using ProjectScheduler;

namespace CustomizedTaskSchedulerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomizedTaskScheduler sched = new CustomizedTaskScheduler();
            sched.AddTask(new CustomizedTask(() => { }, Priority.Low, 10, null));
            sched.AddTask(new CustomizedTask(() => { }, Priority.Medium, 13, null));
            sched.AddTask(new CustomizedTask(() => { }, Priority.High, 11, null));
            sched.AddTask(new CustomizedTask(() => { }, Priority.High, 10, null));
            sched.AddTask(new CustomizedTask(() => { }, Priority.Low, 10, null));

            sched.printAll();
        }
    }
}
