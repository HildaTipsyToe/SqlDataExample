using System;
using System.Collections.Generic;

namespace SqlDataExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SQL sql = new SQL();
            //InsertMethod(sql);
            Console.WriteLine("Search for:");
            string search = Console.ReadLine();
            //List<Person> persons = sql.select(search);
            List<Person> persons/*FromDatetimeList*/ = sql.select(new DateTime(1809, 02, 12));

            if (persons != null && persons.Count > 0)
            {
                foreach (var person in persons)
                {
                    Console.WriteLine(person.Name);
                }
            }
            else Console.WriteLine("Nothing found.");
        }

        private static void InsertMethod(SQL sql)
        {
            Person person = new Person();
            person.Name = "Abraham Lincoln";
            person.dob = new DateTime(1809, 02, 12);
            int? id = sql.insert(person);
            if (id != null)
                Console.WriteLine($"{person.Name}, Born {person.dob} have gotten id : {id}");

            else Console.WriteLine("Something went horribly wrong!");
        }
    }
}
