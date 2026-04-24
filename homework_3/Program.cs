namespace homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入數字(用逗號分隔)：");
            string input = Console.ReadLine();

            string[] numStr = input.Split(',');
            int[] numArr = new int[numStr.Length];
            for (int i = 0; i < numStr.Length; i++)
            {
                numArr[i] = int.Parse(numStr[i]);
            }
            int[] reversed = new int[numArr.Length];

            for (int i = 0; i < numArr.Length; i++)
            {
                reversed[i] = numArr[numArr.Length - 1 - i];
            }

            Console.WriteLine(string.Join(",", reversed));
        }
    }
}
