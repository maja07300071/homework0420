namespace homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入數字(用,分隔)：");
            string input = Console.ReadLine();
            string[] numStr = input.Split(',');
            int[] numArr = new int[numStr.Length];

            for (int i = 0; i < numStr.Length; i++)
            {
                numArr[i] = int.Parse(numStr[i]);
            }
            Array.Sort(numArr);
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();
            for (int i = 0; i < numArr.Length; i++)
            {
                if (numArr[i] % 2 == 0)
                {
                    evens.Add(numArr[i]);
                }
                else
                {
                    odds.Add(numArr[i]);
                }
            }
            Console.WriteLine("偶數：" + string.Join(", ", evens));
            Console.WriteLine("奇數：" + string.Join(", ", odds));
        }
    }
}
