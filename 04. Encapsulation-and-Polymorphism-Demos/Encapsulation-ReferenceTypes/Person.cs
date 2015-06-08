namespace _1._1.Encapsulation_ReferenceTypes
{
    using System;
    using System.Collections.Generic;

    public class Person
    {
        private const int MinPersonAge = 0;
        private const int MaxPersonAge = 120;

        private string name;
        private int age;
        private readonly List<string> aliases = new List<string>();

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(
                        "A person's name cannot be null, empty or whitespace.",
                        "value");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < MinPersonAge || MaxPersonAge < value)
                {
                    throw new ArgumentOutOfRangeException(
                        "value",
                        string.Format("A person's age must be in the range [{0} ... {1}].", MinPersonAge, MaxPersonAge));
                }

                this.age = value;
            }
        }

        public List<string> Aliases
        {
            get
            {
                return this.aliases;
            }
        }

        //public IEnumerable<string> AliasesEnumerable
        //{
        //    get
        //    {
        //        return this.aliases;
        //    }
        //}

        public void AddAlias(string alias)
        {
            this.aliases.Add(alias);
        }
    }
}
