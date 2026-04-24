namespace homework_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入正整數：");
            int i = int.Parse (Console.ReadLine());
            int count = 1;
            while (i > 0)
            {
                for(int j=count;j>0 ; j--)
                {
                    Console.Write(i);
                }
                count++;
                i--;
                Console.WriteLine();
            }
        }
    }
}
