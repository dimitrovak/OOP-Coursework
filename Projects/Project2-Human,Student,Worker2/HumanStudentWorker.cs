using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_Human_Student_Worker2
{
    class HumanStudentWorker
    {
        class Human
        {
            public string firstName;
            public string lastName;

            public Human(string firstName, string lastName)
            {
                this.firstName = firstName;
                this.lastName = lastName;
            }

        }

        class Student : Human
        {
            public string fNumber;

            public Student(string firstName, string lastName, string fNumber) : base(firstName, lastName)
            {
                this.fNumber = fNumber;
            }
            public double avgScore()
            {
                Console.WriteLine("Please enter how many grades does " + this.firstName + " " + this.lastName + " have: ");
                int N = int.Parse(Console.ReadLine());
                double[] Grades = new double[N];
                double sum = 0;
                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine($"Enter grade №{i + 1} (Should be valid - between 2 and 6)");
                    Grades[i] = double.Parse(Console.ReadLine());
                    sum += Grades[i];
                }
                double score = Math.Round((sum / N), 2);
                return score;
            }

        }

        class Worker : Human
        {
            public string company;

            public Worker(string firstName, string lastName, string company) : base(firstName, lastName)
            {
                this.company = company;

            }

            public decimal salaryPerHour()
            {
                Console.WriteLine("Please enter worker " + this.firstName + " " + this.lastName + "'s salary: ");
                decimal salary = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Please enter how many hours per week does worker " + this.firstName + " " + this.lastName + " work: ");
                int hours = int.Parse(Console.ReadLine());
                decimal moneyPerHour = Math.Round((salary / (hours * 4)), 2);
                return moneyPerHour;
            }


        }


        static void Main(string[] args)
        {
            Human Vania = new Human("Vania", "Petrova");
            Console.WriteLine(Vania.firstName + " " + Vania.lastName + " is neither student nor worker.");
            Human Samuil = new Human("Samuil", "Georgiev");
            Console.WriteLine(Samuil.firstName + " " + Samuil.lastName + " is neither student nor worker.");
            Console.WriteLine("------------------------------------------------------------");
            Student Petar = new Student("Petar", "Petrov", "533IMZ");
            Console.WriteLine("The student " + Petar.firstName + " " + Petar.lastName + " with Faculty Number " + Petar.fNumber + " has average score of " + Petar.avgScore());
            Student Maria = new Student("Maria", "Koleva", "521IMR");
            Console.WriteLine("The student " + Maria.firstName + " " + Maria.lastName + " with Faculty Number " + Maria.fNumber + " has average score of " + Maria.avgScore());
            Console.WriteLine("------------------------------------------------------------");
            Worker Ivan = new Worker("Ivan", "Ivanov", "Siemens");
            Console.WriteLine("The worker " + Ivan.firstName + " " + Ivan.lastName + " has a salary/hour of $" + Ivan.salaryPerHour());
            Worker Kalina = new Worker("Kalina", "Dimitrova", "VMWare");
            Console.WriteLine("The worker " + Kalina.firstName + " " + Kalina.lastName + " has a salary/hour of $" + Kalina.salaryPerHour());
        }
    }
}
