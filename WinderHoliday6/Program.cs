using System;

namespace WinderHoliday6
{
    class Program
    {
        /// <summary>
        /// 读取输入的整数，定义成方法，多次调用（如果用户输入的是数字，则返回，否则提示用户重新输入
        /// </summary>
        /// <returns></returns>
        public static int  Read(string s)
        {
            while (true)
            {
                try
                {
                    int a = Convert.ToInt32(s);
                    return a;
                }
                catch
                {
                    Console.WriteLine("请输入其他数");
                    s = Console.ReadLine();
                }
            }
        }
        /// <summary>
        /// 计算数组内的最大值、最小值、和、均值
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] Sum(int[] array,out int a)
        {
            int[] res = { array[0], array[0], 0, 0 };
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > res[0])
                {
                    res[0] = array[i];
                }
                if (array[i] < res[1])
                {
                    res[1] = array[i];
                }
                res[2] += array[i];
            }
            res[3] = res[2] / array.Length;
             a = 1;
            return res;
        }
        /// <summary>
        /// out与用户登录
        /// </summary>
        /// <param name="name">用户名</param>
        /// <param name="password">密码</param>
        /// <param name="massage">登录信息</param>
        /// <returns></returns>
        public static bool IsLogin(string name,string password,out string massage)
        {
            if(name == "群群宝贝"&&password == "811")
            {                
                massage = "登录成功，芜湖";
                return true;
            }
            else if(name !="群群宝贝"&&password =="811")
            {
                massage = "你哪位？";
                return false;
            }
            else if(name == "群群宝贝"&&password !="811")
            {
                massage = "你怎么回事？密码错误！";
                return false;
            }
            else 
            {
                massage = "全错，滚蛋";
                return false;
            }
        }
        /// <summary>
        /// 自己写的TryParse
        /// </summary>
        /// <param name="s"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool MyTryParse(string s, out int number)
        {
             number = 0;
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// ref初使用
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int Ref(ref int a)
        {
            a = 100;
            return a;
        }

        public static void Test(string name,params int[] score)
        {
            int sum = 0;
            for(int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }
            Console.WriteLine("{0}的总成绩是：{1}", name, sum);
        }
        /// <summary>
        /// 方法的重载
        /// </summary>
        /// <param name="a"></param>
        public static void Method(int a)
        {
            Console.WriteLine(a);
        }
        public static void  Method(int a ,int b)
        {
        }
        //递归
        public static void TellStory(int i)
        {
            i++;
            Console.WriteLine("从前有座山");
            Console.WriteLine("山里有座庙");
            Console.WriteLine("庙里有个老和尚");
            Console.WriteLine("老和尚在讲：");
            if (i > 10)
            {
                return;
            }
            TellStory(i);

        }
        public static int Sum(int a,int b)
        {
            int sum = a;
            if (a > b)
            {
                Console.WriteLine("输入无效");
                return 0;
            }
            else
            {
                for(int i = a;i < b; i++)
                {
                    sum += (i+1);
                }
                return sum;
            }
        }
        public static int GetNumber(string s)
        {
            while (true)//这个while写得好
            {
                try
                {
                    int number = Convert.ToInt32(s);
                    return number;
                }
                catch
                {
                    Console.WriteLine("输入错误请重新输入");
                    s = Console.ReadLine();
                }
            }
        }

        public static void JudgeNumber(ref int n1, ref int n2)
        {
            while (true)
            {
                if (n1 < n2)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("第一个数字不能大于等于第二个数字请重新输入第一个数字");
                    string s1 = Console.ReadLine();
                    n1 = GetNumber(s1);
                    Console.WriteLine("请重新输入第二个数字");
                    string s2 = Console.ReadLine();
                    n2 = GetNumber(s2);
                }
            }
        }

        public static int GetSum(int n1, int n2)
        {
            int sum = 0;
            for (int i = n1; i <= n2; i++)
            {
                sum += i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            //string s = Console.ReadLine();
            //int a = Read(s);
            //Console.WriteLine(a);SS

            //int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int a;
            //int[] sum = Sum(array, out a);
            //Console.WriteLine(a);

            //Console.WriteLine("please enter you name and passward");
            //string name  = Console.ReadLine();
            //string password = Console.ReadLine();
            //string msg;
            //IsLogin(name, password, out msg);
            //Console.WriteLine(msg);

            //int num;
            //bool b = MyTryParse("123abc",out num);

            //int a = 1;
            //a = Ref(ref a);
            //Console.WriteLine(a);

            //Test("群群", 100,99,99,100);

            //TellStory(0);

            //提示用户输入两个数字 计算这两个数字之间所有整数的和
            //1、用户只能输入数字
            //2、计算两个数字之间和
            //3、要求第一个数字必须比第二个数字小 就重新输入
            //Console.WriteLine("请输入两个数字");  方法1我写的
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Sum(a, b);
            //Console.WriteLine(c);

            //Console.WriteLine("请输入第一个数");  方法2
            //string strNumberOne = Console.ReadLine();
            //int numberOne = GetNumber(strNumberOne );
            //Console.WriteLine("请输入第二个数");
            //string strNumberTwo = Console.ReadLine();
            //int numberTwo = GetNumber(strNumberTwo);
            //JudgeNumber(ref numberOne,ref numberTwo);
            //int sum = GetSum(numberOne, numberTwo);
            //Console.WriteLine(sum);


            string[] s1 = { "粤群", "李杨", "想我宝贝啦" };
            int[] length = GetLength(s1);
            int number = GetNumber(length);
            Console.WriteLine("{0}是最长的那个字符串",s1[number]);

            string[] s2 = { "粤群", "李杨", "想我宝贝啦" };
            Console.WriteLine(GetLongest(s2));


        }
        public static int[] GetLength(string[] s)
        {
            int[] length = { 0, 0, 0};
            for(int i = 0; i < s.Length; i++)
            {
                length[i] = s[i].Length;
            }
            return length;
        }
        public static int GetNumber(int[] length1)
        {
            int number = 0,x = -1;
            for(int i = 0; i < length1.Length; i++)
            {
                if (number < length1[i])
                {
                    number = length1[i];
                    x = i;
                }
            }
            return x;
        }

        public static string GetLongest(string[] s)
        {
            string max = s[0];
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length > max.Length)
                {
                    max = s[i];
                }             
            }
            return max;
        }
    }
}
