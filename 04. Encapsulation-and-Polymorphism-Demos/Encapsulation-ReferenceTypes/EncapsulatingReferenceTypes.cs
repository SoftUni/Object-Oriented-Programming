namespace _1._1.Encapsulation_ReferenceTypes
{
    using System;

    public class EncapsulatingReferenceTypes
    {
        public static void Main()
        {
            Person pesho = new Person("Pesho", 22);
            pesho.AddAlias("Peter");
            pesho.AddAlias("Petar");
            pesho.AddAlias("Gandalf");

            Console.WriteLine(string.Join(", ", pesho.Aliases));

            pesho.Aliases[0] = "Changed!!!";
            Console.WriteLine(string.Join(", ", pesho.Aliases));

            //Console.WriteLine(string.Join(", ", pesho.AliasesEnumerable));
        }
    }
}
