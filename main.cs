using System;
using System.Xml.Linq;

class MainProgram
{
    public static void Main(string[] args)
    {
        
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("������� ���: ");
        var name = Console.ReadLine();
        Console.Write("��� �������: ");
        var age = checked((byte) int.Parse(Console.ReadLine()));
        Console.Write("��� ���� ��������: ");
        var brithdate = Console.ReadLine();
        Console.WriteLine("���� ��� {0}, ��� ������� {1}, ��� ���� �������� {2}", name, age, brithdate);
        Console.Write("��� �������� ���� ������? ������� ���������� �����: ");
       
        var day = (DaysOfWeek) int.Parse(Console.ReadLine());
        Console.WriteLine("��� ������� ���� ������: {0}", day);

        Console.ReadKey();
     

    }
}
enum DaysOfWeek : byte
{
    Tuesday = 1,
    Monday,
    Wednesday,
    Friday
}
