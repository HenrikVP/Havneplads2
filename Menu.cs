namespace Havneplads2
{
    internal class Menu
    {
        Data data;

        public Menu()
        {
            Start();
        }
        public Menu(Data data)
        {
            this.data = data;

            while (true)
            {
                Start();
            }
        }

        void Start()
        {
            Console.WriteLine("1 Indsæt på ventelist");
            Console.WriteLine("2 Se venteliste");
            Console.WriteLine("3 Træk fra venteliste");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    InsertNew();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    ShowList();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    PullNext();
                    break;
                default:
                    break;
            }
        }

        void InsertNew()
        {
            Console.Write("Indtast navn : ");
            data.WaitingList.Enqueue(Console.ReadLine());
        }

        void ShowList()
        {
            List<string?> tempList = data.WaitingList.ToList();
            for (int i = 0; i < tempList.Count; i++)
            {
                Console.WriteLine($"{i + 1} {tempList[i]}");
            }
        }

        void PullNext()
        {
            Console.WriteLine("Næste på listen er: " + data.WaitingList.Peek());
            Console.Write("Træk fra listen (j/n) ");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.J:
                    Console.WriteLine($"Ok. {data.WaitingList.Dequeue()} er trukket fra listen");
                    break;
                case ConsoleKey.N:
                    Console.WriteLine($"Ok. {data.WaitingList.Peek()} er IKKE trukket fra listen");
                    break;
                default:
                    break;
            }
        }

    }
}
