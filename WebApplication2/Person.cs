using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2
{
    public class Person
    {
        public Person(string username) {
            this.UserName = username;
            this.Age = 0;
        }
        public string UserName { get; set; }
        public int Age { get; set; }
        public decimal salary { get; set; }
        public int GetAge()
        {
            return Age;
        }
        public void M1()
        {
            Console.WriteLine(1);
            Console.WriteLine(2);

        }
        public void M2()
        {

        }
    }
}
