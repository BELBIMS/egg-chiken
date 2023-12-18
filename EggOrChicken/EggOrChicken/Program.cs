internal class Program
{
    static void MyThreadChicken()
    {
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("Курица"); // Выводит слово "Курица" 100 раз
        }
    }

    static void MyThreadAnswer(Thread chicken)
    {
        Thread.Sleep(10); // Приостанавливает выполнение потока на 10 миллисекунд
        bool ans = chicken.IsAlive; // Проверяет, активен ли поток "chicken"
        Console.WriteLine(ans ? "Спор Окончен. Победила Курица." : "Спор окончен. Победило Яйцо."); // Выводит результат спора 
    }
    private static void Main(string args)
    {
        Thread chicken = new(ThreadChicken); // Создаёт новый поток "chicken" и передаёт метод ThreadChicken как делегат
        chicken.Start(); // Запускает поток "chicken"

        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("Яйцо"); // Выводит слово "Яйцо" 100 раз
        }

        MyThreadAnswer(chicken); // Выполняет метод MyThreadAnswer, передавая поток "chicken" в качестве аргумента
    }
}
