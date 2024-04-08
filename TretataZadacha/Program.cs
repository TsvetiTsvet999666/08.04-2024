namespace TretataZadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of people:");
            int n = int.Parse(Console.ReadLine());

            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter information for person {i + 1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());

                Person person = new Person(name, age);
                people.Add(person);
            }

            List<Person> peopleOver30 = people.Where(p => p.Age > 30).OrderBy(p => p.Name).ToList();

            Console.WriteLine("\nPeople over 30 sorted by name:");
            foreach (var person in peopleOver30)
            {
                Console.WriteLine($"Name: {person.Name} , Age:  {person.Age}");
            }

        }
    }
}
