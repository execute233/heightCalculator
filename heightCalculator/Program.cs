namespace heightCalculator;
class Program
{
    public static void Main(string[] args)
    {
    start:
        Console.Write("������������ (��λ:cm) :");
        string? result;
        int height;
        while (true)
        {
            result = Console.ReadLine();
            if (!Int32.TryParse(result, out height))
            {
                //����ֵ
                Console.WriteLine("������������������������룡");
                continue;
            }
            if (height > 250)
            {
                Console.WriteLine("�����ˣ���������������ɣ�");
                continue;
            }
            if (height >= 200)
            {
                Console.WriteLine("����ѧУ�����ܻ�����ô�ߵİɣ�����������������ɣ�");
                continue;
            } else if (height <= 0)
            {
                Console.WriteLine("�Ҹо����Ǿ������������©��֮�㣬����������ɣ�");
                continue;
            } else if (height <= 50)
            {
                Console.WriteLine("��˵���������߶����Ƕ�ͯ����ߣ�����������ɣ�");
                continue;
            } else if (height <= 100) {
                Console.WriteLine("Are you kidding me������������ɣ�");
                continue;
            } else if (height < 150)
            {
                Console.WriteLine("����ѧУû��ô���İɣ�����������ɣ�");
                continue;
            }
            break;
        }
        ProcessBar("���ڼ�������ģ��", "ģ�ͼ�����ϣ�", 3);
        ProcessBar("���ڹ�����ѧģ��", "ģ�͹�����ϣ�", 4);
        ProcessBar("������Ϻ�����  ", "�����ϣ�", 2);
        ProcessBar("����������      ", "������ϣ�", 4);
        result = $"��������ǣ�{height}cm��";
        for (int i = 0; i < result.Length; i++)
        {
            Thread.Sleep(500);
            Console.Write(result[i]);
            
        }
        Console.WriteLine();
        Console.WriteLine("�밴������˳� : )");
        Console.ReadKey();
    }

    public static void ProcessBar(string title,  string success, double time)
    {
        int index = 0;
        char waitChar = '��';
        char processChar = '��';
        int end = 80;
        int now = 0;
        for (; index <= end; index++)
        {
            string outStr = $"\r{title}����{Concat(index, processChar, end - index, waitChar)}��{now}%";
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
