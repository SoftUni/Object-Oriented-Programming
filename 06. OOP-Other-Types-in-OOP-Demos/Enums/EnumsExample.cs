using System;

class EnumExample
{
	static void Main()
	{
	    DayOfWeek day = DayOfWeek.Wed;

		Console.WriteLine(day); // Wed
		
		Console.WriteLine((int)day); // 2

		day = DayOfWeek.Sat;
        Console.WriteLine(++day); // Sun
        Console.WriteLine(++day); // 7

		day = (DayOfWeek) Enum.Parse(typeof(DayOfWeek), "Mon");
		Console.WriteLine(day); // Mon
	}
}
