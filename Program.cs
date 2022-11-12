namespace heightCalculator;
class Program
{
    public static void Main(string[] args)
    {
    start:
        Console.Write("请输入你的身高 (单位:cm) :");
        string? result;
        int height;
        while (true)
        {
            result = Console.ReadLine();
            if (!Int32.TryParse(result, out height))
            {
                //非数值
                Console.WriteLine("您输入的数据有误，请重新输入！");
                continue;
            }
            if (height > 250)
            {
                Console.WriteLine("外星人？？？你重新输入吧！");
                continue;
            }
            if (height >= 200)
            {
                Console.WriteLine("我们学校不可能会有那么高的吧？？？，你重新输入吧！");
                continue;
            } else if (height <= 0)
            {
                Console.WriteLine("我感觉你是九年义务教育的漏网之鱼，你重新输入吧！");
                continue;
            } else if (height <= 50)
            {
                Console.WriteLine("我说的是你的身高而不是儿童的身高！你重新输入吧！");
                continue;
            } else if (height <= 100) {
                Console.WriteLine("Are you kidding me？你重新输入吧！");
                continue;
            } else if (height < 150)
            {
                Console.WriteLine("我们学校没那么矮的吧，你重新输入吧！");
                continue;
            }
            break;
        }
        ProcessBar("正在加载数据模型", "模型加载完毕！", 3);
        ProcessBar("正在构建数学模型", "模型构建完毕！", 4);
        ProcessBar("正在拟合函数中  ", "拟合完毕！", 2);
        ProcessBar("收敛函数中      ", "收敛完毕！", 4);
        result = $"您的身高是：{height}cm。";
        for (int i = 0; i < result.Length; i++)
        {
            Thread.Sleep(500);
            Console.Write(result[i]);
            
        }
        Console.WriteLine();
        Console.WriteLine("请按任意键退出 : )");
        Console.ReadKey();
    }

    public static void ProcessBar(string title,  string success, double time)
    {
        int index = 0;
        char waitChar = '─';
        char processChar = '█';
        int end = 80;
        int now = 0;
        for (; index <= end; index++)
        {
            string outStr = $"\r{title}：├{Concat(index, processChar, end - index, waitChar)}┤{now}%";
            Console.Write(outStr);
            Thread.Sleep((int)(time * 1000.0 / end));
            now = (int) (((double) index + 1) * 100 / (double)end);
            //Console.Write("/r");
            
        }
        Console.WriteLine();
        Console.WriteLine(success);
        
    }
    public static string Concat(int times, char value, int times2, char value2)
    {
        string result = "";
        for (;times > 0;times--)
        {
            result += value;
        }
        for (; times2 > 0; times2--)
        {
            result += value2;
        }
        return result;
    }
}
