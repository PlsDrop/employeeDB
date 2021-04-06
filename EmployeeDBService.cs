using System;
using System.Threading.Tasks;
using Npgsql;
using System.Collections.Generic;

namespace employeeDB
{
    class EmployeeDBService
    {
        private NpgsqlConnection conn;
        public EmployeeDBService(string connString)
        {
            conn = new NpgsqlConnection(connString);
        }
        
        public void OpenConnection()
        {
            conn.Open();
        }

        public ListOfFutureCelebrants GetEmployee()
        {
            using (var cmd = new NpgsqlCommand("SELECT name, date_of_birth FROM employee", conn))
            {
                ListOfFutureCelebrants listOfEmployee = new ListOfFutureCelebrants();
                using (var reader = cmd.ExecuteReader())
                while (reader.Read())
                {
                    string name = reader.GetString(0);
                    DateTime date = reader.GetDateTime(1);
                    listOfEmployee.Add(new Employee(name, date));
                }
                return listOfEmployee;
            }
        }
    }
}