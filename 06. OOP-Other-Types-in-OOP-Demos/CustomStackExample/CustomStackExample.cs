using System;

namespace CustomStackExample
{
    class Student : IComparable<Student>
    {
        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public int CompareTo(Student other)
        {
            if (this.Age > other.Age)
            {
                return 1;
            }
            else if (this.Age < other.Age)
            {
                return -1;
            }

            return 0;
            // return this.Age.CompareTo(other.Age);
        }
    }

    class CustomStackExample
    {
        static void Main()
        {
            var studentStack = new CustomStack<Student>();
            studentStack.Push(new Student("Pesho", 22));
            studentStack.Push(new Student("Penka", 41));
            studentStack.Push(new Student("Gosho", 7));
            studentStack.Push(new Student("Kuci", 15));

            Console.WriteLine(studentStack.Min().Name);

            var intStack = new CustomStack<int>();

            intStack.Push(4);
            intStack.Push(5);
            intStack.Push(14);
            intStack.Push(42);
            intStack.Push(455);

            intStack.Pop();
            intStack.Pop();

            Console.WriteLine(intStack.Min());

            intStack.Clear();

            Console.WriteLine(intStack.Count);
            Console.WriteLine(intStack.IsEmpty);
            Console.WriteLine(intStack);
        }
    }
}
