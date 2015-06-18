namespace SuperRpgGame
{
    using Engine;
    using Interfaces;
    using UI;

    public class SuperRpgGameApp
    {
        public static void Main()
        {
            IRenderer renderer = new ConsoleRenderer();
            IInputReader reader = new ConsoleInputReader();

            SuperEngine engine = new SuperEngine(reader, renderer);

            engine.Run();
        }
    }
}
