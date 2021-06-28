using InternetShop.Models;
using System.Collections.Generic;


namespace InternetShop.Data
{
    public class TestData
    {

       public static List<Employee> Employees { get; } = new()
        {
            new Employee { Id = 1, LastName = "Иванов", FirstName = "Иван", Paronymic = "Иванович", Age = 37 },
            new Employee { Id = 2, LastName = "Сидоров", FirstName = "Сидор", Paronymic = "Сидорович", Age = 30 },
            new Employee { Id = 3, LastName = "Петров", FirstName = "Петров", Paronymic = "Петрович", Age = 25 },

        };
    }
}
