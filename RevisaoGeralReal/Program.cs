using RevisaoGeralReal;
using System;
using System.Security.Cryptography.X509Certificates;

public class ProgramList
{
    static void Main(string[] args)
    {
        ExemploLista1();
        ExemploListaObjeto();

    }

    static void ExemploLista1()
    {
        List<string> list = new List<string>();
        list.Add("a");//add na ultima posicao
        list.Insert(0, "b");//tem q indicar qual posicao

        List<int> listint = new List<int>();
        listint.Add(1);

        foreach (var item in list)//corre o list e add no var item, apaga todo vez q le um novo item
        {
            Console.WriteLine(item);
        }

        List<double> listdouble = new List<double> { 2.4, 5, 7 };
        listdouble.Add(1);

        foreach (var item in listdouble)
        {
            Console.WriteLine(item);
        }

        listdouble.Remove(1);//ele remove o elemento, nao a posicao
        listdouble.RemoveAt(0);//remove a posicao

        list.Sort();//ordena a lista

        bool b = listdouble.Contains(1);

        Console.WriteLine(b);

        //para juntar duas lista usa o List1.AddRange(List2);
    }

    static void ExemploListaObjeto()
    {
        List<Paciente> listapaci = new List<Paciente>();
        Paciente p1 = new Paciente(1, "Elias", "000", "Elias.Elias", new DateTime(1982, 07, 22));
        Paciente p2 = new Paciente(1, "Pedro", "001", "pedro.", new DateTime(2006, 12, 22));
        Paciente p3 = new Paciente(1, "Enzo", "002", "enzo.", new DateTime(2003, 04, 12));
        Paciente p4 = new Paciente(1, "Giovanna", "004", "gio.", new DateTime(2006, 02, 23));
        Paciente p5 = new Paciente(1, "Rogerio", "005", "roges.", new DateTime(2005, 01, 11));

        listapaci.Add(p1);
        listapaci.Add(p2);
        listapaci.Add(p3);
        listapaci.Add(p4);
        listapaci.Add(p5);

        foreach (var p in listapaci)
        {
            Console.WriteLine(p.nome+ "\n" + p.cpf + "\n\n");
        }
    }
}