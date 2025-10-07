namespace LeetCode_2235
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("第一個數字：");
            int a = int.Parse(Console.ReadLine());
            Console.Write("第二個數字：");
            int b = int.Parse(Console.ReadLine());

            Console.Write("二相加等於：");
            Console.Write(Sum(a, b));
            Console.Read();

            //LeetCode 2235
            //1. 看函式  1.回傳是 int  2. 輸入參數是 int num1, int num2
            int Sum(int num1, int num2)
            {
                //1. 輸入
                //int num1;
                //int num2;

                //2. 處理
                int twoNumbers = 0;
                twoNumbers = num1 + num2;

                //3. 輸出
                int result = 0;
                result = twoNumbers;
                return result;


            }
        }
    }
}
