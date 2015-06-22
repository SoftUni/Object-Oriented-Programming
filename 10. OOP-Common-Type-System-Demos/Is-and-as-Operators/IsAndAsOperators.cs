namespace IsAndAsOperators
{
    using System;

    class Shape { }

    class Triangle : Shape { }

    class PalyWithOperatorsIsAndAs
    {
        static void Main(string[] args)
        {
            Object objBase = new Shape();
            if (objBase is Shape)
                Console.WriteLine("objBase is Shape");
            // Result: objBase is Shape

            if (!(objBase is Triangle))
                Console.WriteLine("objBase is not Triangle");
            // Result : objBase is not Triangle

			if (objBase is Object)
				Console.WriteLine("objBase is System.Object");
			// Result : objBase is System.Object

			// "dynamic" is internally System.Object
			// but with runtime binding of the operations
			if (objBase is dynamic)
				Console.WriteLine("objBase is dynamic");
			// Result: objBase is dynamic
			
            Shape b = objBase as Shape;
            Console.WriteLine("b = {0}", b);
            // Result: b = Shape

            Triangle d = objBase as Triangle;
            if (d == null)
                Console.WriteLine("d is null");
            // Result: d is null

            Object o = objBase as object;
            Console.WriteLine("o = {0}", o);
            // Result: o = Shape

            Triangle der = new Triangle();
            Shape bas = der as Shape;
            Console.WriteLine("bas = {0}", bas);
            // Result: bas = Triangle

			Object dyn = objBase as dynamic;
			Console.WriteLine("dyn = {0}", dyn);
			// Result: o = Shape
		}
    }
}