using System;
using System.Collections.Generic;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.MinValue;
            //ENUM
            List<Todo> todo = new List<Todo>() {
            new Todo(){ Description = "Task 1", EstimateHours = 2, Status = Status.Inprogress},
            new Todo(){ Description = "Task 2", EstimateHours = 12, Status = Status.Completed},
            new Todo(){ Description = "Task 3", EstimateHours = 4, Status = Status.OnHold},
            new Todo(){ Description = "Task 5", EstimateHours = 3, Status = Status.Inprogress},
            new Todo(){ Description = "Task 6", EstimateHours = 6, Status = Status.Completed},
            new Todo(){ Description = "Task 4", EstimateHours = 8, Status = Status.NotStarted},
            new Todo(){ Description = "Task 7", EstimateHours = 1, Status = Status.Inprogress},
            new Todo(){ Description = "Task 8", EstimateHours = 10, Status = Status.NotStarted},
            new Todo(){ Description = "Task 9", EstimateHours = 14, Status = Status.Deleted}

            };

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hello World!");
        }
    }
    class Todo{

        public string Description { get; set; }
        public int EstimateHours { get; set; }
        public Status Status { get; set; }
    }
    enum Status
    {
        NotStarted,
        Inprogress,
        OnHold,
        Completed,
        Deleted
    }
}

