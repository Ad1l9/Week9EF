using TaskEF.Models;
using TaskEF.Services;

namespace TaskEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentService service = new();
            service.Create(new Student
            {
                Name = "Leyla",
                Surname = "Shafiyeva",
                AvgPoint = 100
            });


        }
    }
}