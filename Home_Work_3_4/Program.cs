namespace Home_Work_3_4
{
    class Program
    {
        static void Main()
        {
            Color print = new Color(ConsoleColor.Yellow);
            print.Print("Hello world!");

            Printer printer = print;
            printer.Print("Hello world!");

            Color newPrint = new Color(ConsoleColor.Blue);
            newPrint.Print("Hello world!");

            Console.ReadKey();
        }
    }
}