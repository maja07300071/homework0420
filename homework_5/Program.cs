namespace homework_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入中華民國年份");
            int year = int.Parse(Console.ReadLine());
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine($"{year} 是閏年");
            }
            else
            {
                Console.WriteLine($"{year} 不是閏年");
            }
        }
    }
}
