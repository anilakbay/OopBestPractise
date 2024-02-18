using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypes
{
    public class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;

            sayi2 = 100;

            //Console.WriteLine("Sayı 1:" + sayi1);
            //Console.ReadLine();

            //arrays,class,interface...reference types

            //int[] sayilar1 = new int[] { 1, 2, 3 };
            //int[] sayilar2 = new int[] { 10, 20, 30 };

            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;

            //Console.WriteLine("Sayılar1[0] = " + sayilar1[0]);
            //Console.ReadLine();

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Buse";

            person2 = person1;
            person1.FirstName = "Cansu";

            //Console.WriteLine(person2.FirstName);
            //Console.ReadLine();

            Customer customer = new Customer();
            customer.FirstName = "Ahmet";
            customer.CreditCardNumber = "123456789";

            Employee employee = new Employee();
            employee.FirstName = "Buket";

            Person person3 = customer;
            customer.FirstName = "Merve";

            //Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager(); //instance(örneğini) oluşturuyoruz!
            personManager.Add(employee);
            

        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    //base class: temel sınıf : Person
    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
            Console.ReadLine();    
        }
    }
}
