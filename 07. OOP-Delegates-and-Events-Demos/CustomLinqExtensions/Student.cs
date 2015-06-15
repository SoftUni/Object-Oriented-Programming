namespace CustomLinqExtensions
{
    public class Student
    {
        public Student(string name, int age, double averageGrade)
        {
            this.Name = name;
            this.Age = age;
            this.AverageGrade = averageGrade;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public double AverageGrade { get; set; }
    }
}
