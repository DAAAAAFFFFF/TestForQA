using MainApp.Models;
using MainApp.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region declaringVariables

            var personsBSUIR = new List<Person>
            {
                new Person { FIO = "Artem Zavadski", Age = 21 },
                new Person { FIO = "Igor Byzlanov", Age = 25 },
                new Person { FIO = "Anton Protasevich", Age = 20 },
                new Person { FIO = "Ilya Vasyakov", Age = 22 },
                new Person { FIO = "Artem Gontar", Age = 21 }
            };

            var BSUIR = new University() { Name = "BSUIR", Persons = personsBSUIR };

            var personsGGTY = new List<Person>
            {
                new Person { FIO = "Artem Navatskiy", Age = 31 },
                new Person { FIO = "Alexey Sich", Age = 35 },
                new Person { FIO = "Anton Naval'niu", Age = 21 },
                new Person { FIO = "Ilya Goroshenya", Age = 22 },
                new Person { FIO = "Artem Femalyok", Age = 22 }
            };

            var GGTY = new University() { Name = "GGTY", Persons = personsGGTY };

            var personsBNTU = new List<Person>
            {
                new Person { FIO = "Lexa Navatskiy", Age = 31 },
                new Person { FIO = "Vladimir Pytin", Age = 89 },
                new Person { FIO = "Lexa Naval'niu", Age = 69 },
                new Person { FIO = "Ilya Karzyk", Age = 21 },
                new Person { FIO = "Vasya Nikto", Age = 45 }
            };

            var BNTU = new University() { Name = "BNTU", Persons = personsBNTU };
            #endregion

            var universities = new List<University> { BSUIR, GGTY, BNTU };

            var names = GetPersonsName.GetNames(universities);
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
