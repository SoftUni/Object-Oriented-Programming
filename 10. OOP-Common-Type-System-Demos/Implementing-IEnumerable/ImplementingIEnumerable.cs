using System;
using System.Collections.Generic;

class ImplementingIEnumerable
{
	static void Main()
	{
		LinkedList<string> list =
			new LinkedList<string>("1st element",
			new LinkedList<string>("2nd element",
			new LinkedList<string>("3rd element")));

	    foreach (var item in list)
	    {
	        Console.WriteLine(item);
	    }

        //IEnumerator<string> enumerator = list.GetEnumerator();
        //while (enumerator.MoveNext())
        //{
        //    Console.WriteLine(enumerator.Current);
        //}

        //enumerator.Reset();
	}
}
