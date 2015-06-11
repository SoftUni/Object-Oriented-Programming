namespace StructVsClass
{
    using System;

    public class StructClassComparison
    {
        private const long PixelsCount = 1920 * 1080;

        static void Main()
        {
            long initialStructMem = GC.GetTotalMemory(true);
            var structColors = new ColorStruct[PixelsCount];
            for (int i = 0; i < structColors.Length; i++)
            {
                structColors[i] = new ColorStruct();
            }

            long postStructMem = GC.GetTotalMemory(true);
            Console.WriteLine("{0} instances of struct: {1}KB",
                PixelsCount, (postStructMem - initialStructMem) / 1000);

            long initialClassMem = GC.GetTotalMemory(true);
            var classColors = new ColorClass[PixelsCount];
            for (int i = 0; i < classColors.Length; i++)
            {
                classColors[i] = new ColorClass();
            }

            long postClassMem = GC.GetTotalMemory(true);
            Console.WriteLine("{0} instances of class: {1}KB", 
                PixelsCount, (postClassMem - initialClassMem) / 1000);
        }
    }
}
