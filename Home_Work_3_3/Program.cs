namespace Home_Work_3_3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ключ доступу: ");
            string key = Console.ReadLine();
            DocumentWorker worker;

            switch (key)
            {
                case "PRO": worker = new ProDocumentWorker();
                    break;
                case "EXPERT": worker= new ExpertDocumentWorker();
                    break;
                default: Console.WriteLine("Ключ неавiрний");
                    worker = new DocumentWorker();
                    break;
            }

            worker.OpenDocument();

            worker.EditDocument();

            worker.SaveDocument();

            Console.ReadKey();

        }
    }
}