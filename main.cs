using System;
using System.Xml.Linq;

class MainProgram
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("������� ���:");
        var name = Console.ReadLine();
        Console.Write("��� �������:");
        var age = checked((byte) int.Parse(Console.ReadLine()));
        Console.Write("��� ���� ��������:");
        var brithdate = Console.ReadLine();
        Console.WriteLine("Your name is {0}, age is {1}, brithdate {2}", name, age, brithdate);
        Console.Write("What is your favorite day of week? ");
        var day = (DayOfWeek) int.Parse(Console.ReadLine());
        Console.WriteLine("Your favorite day is {0}", day);

        Console.ReadKey();

    }
}
enum DaysOfWeek : byte
{
    Tuesday,
    Monday,
    Wednesday,
    Friday
}















/*        string MyName = "���������";
        byte MyAge = 32;
        bool MyPet = true;
        float MyShoeSize = 44.4f;

        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("��� ��� �����?");
        Console.WriteLine("���� ����� " + MyName);
        Console.WriteLine(MyName + ", ������� ��� ���?");
        Console.WriteLine("��� " + MyAge);
        Console.WriteLine(MyName + ", � ��� ���� �������� ��������?");
        Console.WriteLine(MyPet);
        Console.WriteLine(MyName + ", ����� � ��� ������ ����?");
        Console.WriteLine("��� ������ ���� " + MyShoeSize + "\n");
        //Console.ReadKey();
        
        //����� ����� ���� ������
        Console.WriteLine("Intmin {0}", int.MinValue);
        Console.WriteLine("IntMax {0}", int.MaxValue + "\n");
        //Console.ReadKey();
        
        //������ �� ��������
        DaysOfWeek MyFavoriteDay;

        MyFavoriteDay = DaysOfWeek.Monday;
        Console.WriteLine(MyFavoriteDay);

       
        Semaphore MySemaphore;
        MySemaphore = Semaphore.Green;
        Console.WriteLine(MySemaphore);
        Console.WriteLine("\t������,\n ���!");

        string name = "Jane";
        byte age = 32;
        string favcolor = "black";

        Console.WriteLine("{0}\n{1}\n{2}", name, age, favcolor);


        Console.ReadKey();
    }
}

enum DaysOfWeek : byte
{
    Tuesday,
    Monday,
    Wednesday,
    Friday
}

enum Semaphore: int
{
    Red = 100,
    Yellow = 200,
    Green = 300
}*/