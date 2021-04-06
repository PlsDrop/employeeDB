using System;
using System.Collections.Generic;

namespace employeeDB
{
    class Employee
    {
        public Employee(string name_, DateTime birthDay_)
        {
            name = name_;
            birthDay = birthDay_;
            AgeCalc();
        }
        public string name;
        public DateTime birthDay; 

        public int age;

        private void AgeCalc()
        {
            age = (DateTime.Today.Year - birthDay.Year - 1) +
            (((DateTime.Today.Month > birthDay.Month) || 
            ((DateTime.Today.Month == birthDay.Month) && (DateTime.Today.Day >= birthDay.Day))) ? 1 : 0);
        }
        public int CompareTo(Employee p)
        {
            int i = this.birthDay.Month.CompareTo(p.birthDay.Month);
            if (i == 0)
            {
                return this.birthDay.Day.CompareTo(p.birthDay.Day);
            }
            else
            {
                return i;
            }
        }

    }
}