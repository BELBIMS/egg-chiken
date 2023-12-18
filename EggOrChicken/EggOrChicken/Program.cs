internal class Program
{
    static void MyThreadChicken()
    {
        for (int i = 0; i < 100; i++)
            Console.WriteLine("Курица");
    }

    static void MyThreadAnswer(Thread chicken)
    {
        Thread.Sleep(10);
        bool ans = chicken.IsAlive;
        Console.WriteLine(ans ? "Спор Окончен. Победила Курица." : "Спор окончен. Победило Яйцо.");
    }
    private static void Main(string[] args)
    {
        Thread chicken = new(MyThreadChicken);
        chicken.Start();

        for (int i = 0; i < 100; i++)
            Console.WriteLine("Яйцо");

        MyThreadAnswer(chicken);
    }
}