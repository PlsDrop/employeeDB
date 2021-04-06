using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Npgsql;

namespace employeeDB
{
    class Program
    {
        static void Main(string[] args)
        {
            string connString = "Host=127.0.0.1;Username=birthday_app;Password=12345;Database=birthday";
            EmployeeDBService empService = new EmployeeDBService(connString);
            
            empService.OpenConnection();
            Console.WriteLine(empService.GetEmployee().ToString(2));
            
            
           
           
           
            // List<string> employeeList = empService.GetEmployee();
            
            // foreach(string emp in employeeList)
            // {
            //     Console.WriteLine(emp);
            // }
        }
    }

    class Pul
    {
        public static string Pularisation(int number, string one, string couple, string many)
        {
            if(number < 100 && number >= 5 && number <= 20)
                return $"{number} {many}";
            
            else if(number % 10 == 0)
                return $"{number} {many}";
            
            else if(number % 10 == 1)
                return $"{number} {one}";
            
            else if(number % 10 >= 2 && number % 10 <= 4)
                return $"{number} {couple}";
            
            else if(number % 10 >= 5 && number % 10 <= 9)
                return $"{number} {many}";
            
            else 
                return "";
        }
    }
}
