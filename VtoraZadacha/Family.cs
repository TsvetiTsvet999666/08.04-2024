using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VtoraZadacha
{
    public class Family
    {
        private List<Person> members;
        
        public  Family()
        {
            members = new List<Person>();
        }
        public void AddMember(Person person) // Пробвах по няколко начина но не иска да се махне червената вълна
        {
            members.Add(person);
        }

        public void Print()
        {
            foreach (var person in members.OrderBy(p => p.Name))
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
        }
    }
}
