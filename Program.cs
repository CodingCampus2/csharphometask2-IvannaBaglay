using System;
using CodingCampusCSharpHomework;

namespace HomeworkTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Task2, string> TaskSolver = task =>
            {
                const int padding = Task2.Padding;
                const int decoratingSingsCount = padding / 2;
                return $"{new string(task.DecorativeSign, decoratingSingsCount), -padding}{ task.Balance:C}{new string( task.DecorativeSign, decoratingSingsCount), padding}";
            };

            Task2.CheckSolver(TaskSolver);
        }
    }
}
