using System;
using System.Collections;

namespace MyApp
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public override string ToString()
        {
            return "ID = " + ID.ToString() + ", Name= " + Name.ToString() + ", Gender= " + Gender.ToString();
        }
    }

    internal class Program
    {
      static IEnumerable studentEnumerable = new List<Student>()
            {
                new Student { ID = 1, Name = "John", Gender = "Male" },
                new Student{ID=2, Name="Jane", Gender="Female"},
                new Student{ID=3, Name="Jason", Gender="Male"},
                new Student{ID=4, Name="Elle", Gender="Female"},
                new Student{ID=5, Name="Bob", Gender="Male"},
                new Student{ID=6, Name="Ben", Gender="Male"},

            };
       static void PrintIenumerable()
        {
            Console.WriteLine("IEnumerable");
            foreach (var item in studentEnumerable)
            {
                Console.WriteLine(item.ToString());
            }
        }

        static void PrintEnumerator()
        {
            Console.WriteLine("IEnumerator");
            var studentEnumerator = studentEnumerable.GetEnumerator();
            studentEnumerator.Reset();
            while (studentEnumerator.MoveNext())
            {
                Console.WriteLine(studentEnumerator.Current.ToString());
            }
        }

        static void Print(IList<Student> list)
        {
            Console.WriteLine("IList - Count: {0}", list.Count);
            foreach (var item in list) {
              
                Console.WriteLine(item.ToString());
            }

            list.RemoveAt(1);

            Console.WriteLine("After remove");
            foreach (var item in list)
            {

                Console.WriteLine(item.ToString());
            }
        }
        static void Main(string[] args)
        {

            PrintIenumerable();
            Console.WriteLine();
            PrintEnumerator();
            Console.WriteLine();

            List<Student> lstStudent = new List<Student>() {
                new Student { ID = 1, Name = "John", Gender = "Male" },
                new Student{ID=2, Name="Jane", Gender="Female"},
                new Student{ID=3, Name="Jason", Gender="Male"},
                new Student{ID=4, Name="Elle", Gender="Female"},
                new Student{ID=5, Name="Bob", Gender="Male"},
                new Student{ID=6, Name="Ben", Gender="Male"},

            };

            Print(lstStudent);



        }
    }
}
