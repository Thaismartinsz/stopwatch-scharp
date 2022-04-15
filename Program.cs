    using System.Threading;

    Menu();

    static void Menu() 
    {
        Console.Clear();
        Console.WriteLine("S = Segundos");
        Console.WriteLine("M = Minuto");
        Console.WriteLine("0 = Sair");
        Console.WriteLine("Quanto tempo deseja contar?");
    }


    static void Start(int time)
    {
        int currenttTime = 0;

        while (currenttTime != time)
        {
            Console.Clear();
            currenttTime++;
            Console.WriteLine(currenttTime);
            Thread.Sleep(1000);
        }

        Console.Clear();
        Console.WriteLine("Stopwatch finalizado!");
        Thread.Sleep(2500);
    }
