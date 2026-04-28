namespace homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入數字(用逗號分隔)：");
            string input = Console.ReadLine();

            string[] numStr = input.Split(',');
            string[] reversed = new string[numStr.Length];

            for (int i = 0; i < numStr.Length; i++)
            {
                reversed[i] = numStr[numStr.Length - 1 - i];
            }

            Console.WriteLine(string.Join(",", reversed));
        }
    }
}
