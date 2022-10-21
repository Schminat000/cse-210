using unit03_jumper;


namespace unit03_jumper
{
    // The program's entry point.
    class Program
    {
        // Starts the program using the given arguments.
        static void Main(string[] args)
        {
            Director director = new Director();
            director.StartGame();
        }
    }
}