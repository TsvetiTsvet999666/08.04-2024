using System.Reflection;
using System;

namespace Zadacha___1
{
    internal class Program
    {
        static void Main()
        {          
            Person human1 = new Person();
            Person human2 = new Person();
            Person human3 = new Person();
           
            human1.name = "Pesho";
            human1.age = 20;
            human1.IntroduceYourself();
            
            human2.name = "Gosho";
            human2.age = 18;
            human2.IntroduceYourself();

            human3.name = "Stamat";
            human3.age = 43; 
            human3.IntroduceYourself();
        }
    }
}
