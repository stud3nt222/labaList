using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

class Programs
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;
        // створив списки ArrayList і LinkedList
        ArrayList arrayList = new ArrayList(10);
        LinkedList<int> linkList = new LinkedList<int>();
        int x = 100000; // кільк. ел. у списку
        int n = 1000; // кільк. ел. для вставки
        ZapovnyaList(x, arrayList, linkList);
        ElementDostyp(x, arrayList, linkList);
        PochatokVstavka(n, x, arrayList, linkList);
        KinecVstavka(n, x, arrayList, linkList);
        SeredinaVstavka(n, x, arrayList, linkList);
    }
    // мето для заповнення списків випадковими числами
    public static void ZapovnyaList(int x, ArrayList arrayList, LinkedList<int> linkList)
    {
        Random rand = new Random();
        var swatch = new Stopwatch(); // таймер для arraylist
        var swat4 = new Stopwatch(); // таймер для linkedlist
        Console.WriteLine("\nЗаповнення списків");
        swatch.Start();
        for (int i = 0; i < x; i++)
        {
            arrayList.Add(rand.Next(1, x));
        }
        swatch.Stop();
        Console.WriteLine(swatch.Elapsed.ToString());

        swat4.Start();
        for (int i = 0; i < x; i++)
        {
            linkList.AddLast(rand.Next(1, x));
        }
        swat4.Stop();
        Console.WriteLine(swat4.Elapsed.ToString());

        Console.WriteLine("=================");

    }
    // метод для вимірювання часу доступу до елементів за індексом та ітератором
    public static void ElementDostyp(int x, ArrayList arrayList, LinkedList<int> linkList)
    {
        var arrayListindex = new Stopwatch(); // таймер для arraylist доступ за індексом
        var arrayListiteration = new Stopwatch(); // таймер для arraylist за ітератором
        var linkedListiterator = new Stopwatch(); // таймер для linkedlist за ітератором
        Random rand = new Random();
        // доступ до елемента arraylist за інд.
        Console.WriteLine("\nДоступ за індексом");
        arrayListindex.Start();
        Console.WriteLine(arrayList[rand.Next(0, x)]);
        arrayListindex.Stop();
        Console.WriteLine("ArrayList: " + arrayListindex.Elapsed.ToString());
        Console.WriteLine("LinkedList: нема доступу");

        Console.WriteLine("\nДоступ за ітератером");
        // доступ до елента arraylist через ітерат.
        arrayListiteration.Start();
        foreach (int i in arrayList)
        {
        }
        arrayListiteration.Stop();
        Console.WriteLine("ArrayList: " + arrayListiteration.Elapsed.ToString());
        // доступ до елемента linkedlist через ітерат.
        linkedListiterator.Start();
        foreach (int i in linkList)
        {
        }
        linkedListiterator.Stop();
        Console.WriteLine("LinkedList: " + linkedListiterator.Elapsed.ToString());

        Console.WriteLine("=================");
    }
    // метод для вимірювання часу вставки елементів на початок списку
    public static void PochatokVstavka(int n, int x, ArrayList arrayList, LinkedList<int> ints)
    {
        var arrayListpochatok = new Stopwatch();
        var linkListpochatok = new Stopwatch();
        Random rand = new Random();
        Console.WriteLine("\nВставка на початку списку");
        arrayListpochatok.Start();
        for (int i = 0; i < n; i++)
        {
            arrayList.Insert(0, rand.Next(1, x));
        }
        arrayListpochatok.Stop();
        Console.WriteLine("ArrayList: " + arrayListpochatok.Elapsed.ToString());

        linkListpochatok.Start();
        for (int i = 0; i < n; i++)
        {
            ints.AddFirst(rand.Next(1, x));
        }
        linkListpochatok.Stop();
        Console.WriteLine("LinkedList: " + linkListpochatok.Elapsed.ToString());

        Console.WriteLine("=================");
    }
    // метод для вимірювання часу вставки елементів в середину списку
    public static void SeredinaVstavka(int n, int x, ArrayList arrayList, LinkedList<int> ints)
    {
        var arrayListseredina = new Stopwatch();
        var linkListseredina = new Stopwatch();
        Random rand = new Random();
        Console.WriteLine("\nВставка в середину списку");
        int arrayseredina = arrayList.Count / 2;
        int linkedseredina = ints.Count / 2;
        arrayListseredina.Start();
        for (int i = 0; i < n; i++)
        {
            arrayList.Insert(arrayseredina, rand.Next(1, x));
        }
        arrayListseredina.Stop();
        Console.WriteLine("ArrayList: " + arrayListseredina.Elapsed.ToString());

        int v = 0;
        int g = 0;
        foreach (int item in ints)
        {
        if (v == linkedseredina)
        {
        g = item;
        }
        v++;
        }
        LinkedListNode<int> node = ints.Find(g);
        linkListseredina.Start();
        for (int i = 0; i < n; i++)
        {
            ints.AddAfter(node, rand.Next(1, x));
        }
        linkListseredina.Stop();
        Console.WriteLine("LinkedList: " + linkListseredina.Elapsed.ToString());

        Console.WriteLine("=================");
    }
    // метод для вимірювання часу вставки елементів в кінець списку
    public static void KinecVstavka(int n, int x, ArrayList arrayList, LinkedList<int> ints)
    {
        var arrayListkinec = new Stopwatch();
        var linkListkinec = new Stopwatch();
        Random rand = new Random();
        Console.WriteLine("\nВставка в кінець списку");
        arrayListkinec.Start();
        for (int i = 0; i < n; i++)
        {
            arrayList.Add(rand.Next(1, x));
        }
        arrayListkinec.Stop();
        Console.WriteLine("ArrayList: " + arrayListkinec.Elapsed.ToString());

        linkListkinec.Start();
        for (int i = 0; i < n; i++)
        {
            ints.AddLast(rand.Next(1, x));
        }
        linkListkinec.Stop();
        Console.WriteLine("LinkedList: " + linkListkinec.Elapsed.ToString());

        Console.WriteLine("=================");
    }
}
