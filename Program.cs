namespace LeetCode_2235
{
    internal class Program
    {
        // 主程式進入點
        static void Main(string[] args)
        {
            //C#的輸入與輸出
            //知識點：Ch2 建立C#應用程式，主控台應用程式的輸出與輸入、程式註解、程式碼縮排
            //知識點：Ch3 變數、資料型別與運算子，變數的宣告、變數的初值、指定敘述、整數資料型別、字串資料的型別轉換
            //知識點：Ch7 函數，呼叫擁有參數和傳回值的函數、函數的執⾏過程

            Console.Write("第一個數字：");  //輸入第一個數字
            string str1 = Console.ReadLine();  //讀取使用者輸入的字串指定給宣告變數str1的初值
            int a = Convert.ToInt32(str1);  //將字串轉換成整數並指定給變數a

            Console.Write("第二個數字：");  //輸入第二個數字
            string str2 = Console.ReadLine();  //讀取使用者輸入的字串指定給宣告變數str2的初值
            int b = Convert.ToInt32(str2);  //將字串轉換成整數並指定給變數b

            Console.Write("二數相加等於：");  //輸出兩數相加結果的提示字串
            Console.Write(Sum(a, b));  //呼叫擁有參數和傳回值的Sum函數，並帶入兩個引數a和b，將傳回值輸出到主控台
            Console.Read(); //等待使用者按下任意鍵後結束程式


            //LeetCode 2235
            //知識點：Ch7 函數，建立C#函數、函數的參數列、函數的傳回值、區域函數
            //知識點：Ch3 變數、資料型別與運算子，變數的宣告、變數的初值、指定敘述、整數資料型別

            //解題思路
            //區域函數  1.傳回值是整數資料型別 int  2. 形式變數是兩個整數資料型別 int num1, int num2
            int Sum(int num1, int num2)
            {
                //1. 輸入
                //int num1; 形式變數不用再宣告
                //int num2; 形式變數不用再宣告

                //2. 處理
                int twoNumbers = 0; //宣告一個整數變數並設定初值為0來存放兩數相加的結果
                twoNumbers = num1 + num2; //將兩個形式變數相加並將結果指定給twoNumbers變數

                //dddefewtrw


                //3. 輸出
                int result = 0; //宣告一個整數變數並設定初值為0來存放傳回值
                result = twoNumbers;  //將twoNumbers的值指定給result變數
                return result; //傳回result變數的值
            }
            //結束簽名ChouYS
        }
    }
}
