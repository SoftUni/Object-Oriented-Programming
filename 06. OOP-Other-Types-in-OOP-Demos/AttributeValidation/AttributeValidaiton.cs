namespace AttributeValidation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    using AttributeValidation.Attributes;
    using AttributeValidation.Models;

    public class AttributeValidaiton
    {
        static void Main()
        {
            var warriors = new List<Warrior>()
            {
                new Warrior()
                {
                    Name = "Gosho",
                    //Weapon = new Weapon()
                },
                new Warrior()
                {
                    //Name = "Pesho",
                    Weapon = new Weapon()
                },
                new Warrior()
                {
                    //Name = "Gencho",
                    //Weapon = new Weapon()
                }
            };

            try
            {
                ValidateRequiredProperties(warriors);
            }
            catch (AggregateException ex)
            {
                Console.Error.WriteLine(ex.Flatten());
            }
        }

        private static void ValidateRequiredProperties<T>(IEnumerable<T> entities)
        {
            var requiredProperties = typeof(T)
                .GetProperties()
                .Where(pr => pr.GetCustomAttributes(false)
                    .Any(a => a is RequiredAttribute));

            var exceptions = new List<Exception>();
            foreach (var warrior in entities)
            {
                foreach (var prop in requiredProperties)
                {
                    if (prop.GetValue(warrior) == null)
                    {
                        var ex = new ArgumentNullException(prop.Name);

                        exceptions.Add(ex);
                    }
                }
            }

            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }
        }
    }
}
