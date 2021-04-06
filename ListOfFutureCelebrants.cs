using System;
using System.Collections.Generic;

namespace employeeDB
{
    class ListOfFutureCelebrants : List<Employee>
    {
        public DateTime today = DateTime.Today;  
        // public DateTime nextMonth = DateTime.Today.AddMonths(1);  
        // public DateTime nextMonth2 = DateTime.Today.AddMonths(2);

        public string ToString(int monghtLenght)
        {   
            string result = "";
            for (int i = 0; i <= monghtLenght; i++)
            {
                result += $"{today.AddMonths(i).ToString("MMMM yyyy")}\n";
                foreach (Employee employer in this)
                {
                    if (employer.birthDay.Month == today.AddMonths(i).Month)
                        result += $"({employer.birthDay.ToString("dd")}) - {employer.name} ({Pul.Pularisation(employer.age,"год","года","лет")})\n";
                }
            }
            return result;
        }     
    }
}