using System;

delegate int StringDelegate(string value); 

public class MultiDelegates
{
	static int PrintString(string str)
	{
		Console.WriteLine("Str: {0}", str);
		return 1;
	}

	int PrintStringLength(string value)
	{
		Console.WriteLine("Length: {0}", value.Length);
		return 2;
	}

	public static void Main()
	{
	    var del = new StringDelegate(PrintString);
	    var md = new MultiDelegates();
	    del += md.PrintStringLength;

	    int result = del("Pesho");
	    Console.WriteLine(result);
	}
}
