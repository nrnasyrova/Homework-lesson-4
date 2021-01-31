using System;
using HomeworkLesson4Library;

namespace HomeworkLesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            // assignment1();
            // assignment2();
            // assignment3();
            // assignment4();
            assignment5();
        }

        static void assignment1()
        {
            Console.Write("Side 1: ");
            double.TryParse(Console.ReadLine(), out double side1);
            Console.Write("Side 2: ");
            double.TryParse(Console.ReadLine(), out double side2);

            Rectangle rectangle = new Rectangle ( side1,  side2 );
  
            Console.WriteLine
            (
                $"Area: {rectangle.Area}\n" +
                $"Perimeter: {rectangle.Perimeter}"
            );
        }

        static void assignment2()
        {
            Book book = new Book ("Harry Potter", "J.K.Rowling", "Harry's struggle against Lord Voldemort");
            book.Show();
        }

        static void assignment3()
        {
            Scales scales = new Scales("Xiaomi", "white", 200);
            scales.Weigh(160);
        }
    
        static void assignment4()
        {
            Converter converter = new Converter(10, 10, 10);
            converter.ConvertToSomoni(true, false, false);
            converter.ConvertFromSomoni(true, false, false);
        }

        static void assignment5()
        {
            Employee employee = new Employee("Yo", "Kim", "manager", 2);
            employee.CalculateSalary();
        }

    }
}
