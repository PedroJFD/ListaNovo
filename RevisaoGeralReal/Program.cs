using System;

public class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>();
        list.Add("a");
        list.Insert(0, "b");//tem q indicar qual posição

        List<int> listint = new List<int>();
        listint.Add(1);

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}