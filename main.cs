using System;

class MainProgram
{
    public static void Main(string[] args)
    {
        string MyName = "���������";
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
        Console.WriteLine("��� ������ ���� " + MyShoeSize);
        Console.ReadKey();
    }
}