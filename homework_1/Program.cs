namespace homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入正整數");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} 是偶數");
            }
            else
            {
                Console.WriteLine($"{number} 是奇數");
            }
        }
    }
}
