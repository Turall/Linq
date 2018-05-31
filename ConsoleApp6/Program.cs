using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> person = new List<Person>()
          {
                 new Person(){ Name = "Andrey", Surname="Spenst", Age = 24, City = "Kyiv", IsStudent = true },
                 new Person(){ Name = "Liza", Surname="Mats", Age = 18, City = "Moscow", IsStudent = true },
                 new Person(){ Name = "Oleg", Surname="Mufaizalov", Age = 15, City = "London", IsStudent = true },
                 new Person(){ Name = "Sergey", Surname="Yasnikov", Age = 55, City = "Kyiv", IsStudent = false },
                 new Person(){ Name = "Ali", Surname="Rasul", Age = 19, City = "Baku", IsStudent = true },
                 new Person(){ Name = "Afar", Surname="Allazov", Age = 36, City = "Baku", IsStudent = false },
                 new Person(){ Name = "Nizami", Surname="Mamedov", Age = 47, City = "Ganja", IsStudent = false },
                 new Person(){ Name = "Nesimi", Surname="Aliyev", Age = 25, City = "Khirdalan", IsStudent = false }

           };

            //1.task
            Console.WriteLine();
            Console.WriteLine("Выбрать людей, старших 25 лет");
            var a = person.Where(e => e.Age > 25);
            foreach (var item in a)
            {
                Console.WriteLine(item.Age);
            }
            Console.WriteLine("Выбрать людей, проживающих не в Киеве.");
            Console.WriteLine();
            //2.task 
            foreach (var item in person.Where(e => e.City != "Kyiv"))
            {
                Console.WriteLine(item.City);
            }

            Console.WriteLine();
            Console.WriteLine("Выбрать имена людей, проживающих в Киеве.");
            //3.task
            foreach (var item in person.Where(e => e.City.Equals("Kyiv")).Select(e => e.Name))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Выбрать людей старших 35 лет с именем Sergey");
            //4.task
            foreach (var item in person.Where(e => e.Age > 35 && e.Name.Equals("Sergey")))
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Выбрать людей, проживающих в Москве.");
            foreach (var item in person.Where(e => e.City.Equals("Moscow")))
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine();
            Console.WriteLine("6) Telebe olanlari Student tipine cast elemek");
            var IsStudent = person.Where(i => i.IsStudent).Select(e => new Student()
            {
                Age = e.Age,
                Fullname = string.Format("{0}: {1}", e.Name, e.Surname)
            }).ToArray();

            foreach (var item in IsStudent)
            {
                Console.WriteLine(item.Fullname + "\n" + item.Age);
            }
            Console.WriteLine();
            Console.WriteLine("7) Anonim tip yaratmaq ve bu tipe IsEven property-si elave etmek(yasi cut reqem olanlar true tek reqem olanlar ise false)");
            var IsEven = person.Select(e => new { name = e.Name, IsEveen = e.Age % 2 == 0 });
            foreach (var item in IsEven)
            {
                Console.WriteLine(item.IsEveen);
            }

            Console.WriteLine();
            Console.WriteLine("1)email validasiya eden extension metod yaratmaq string tipi ucun. ");
        }
    }
}
