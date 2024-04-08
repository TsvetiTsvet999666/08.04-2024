using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha___1
{
    public class Person
    {
        public string name;
        public int age;
        
        public void IntroduceYourself()
        {
            Console.WriteLine($"I am {name} and I'm {age} years. Nice to meet you! ");
        }
    }
}
