using System;

//ref link:https://www.youtube.com/watch?v=DdmTWturP3Y&list=PLAE7FECFFFCBE1A54&index=9&t=4s
//

class MainClass
{
    //static bool waaaaaa(int i) { return i > 5; }

    static void Main()
    {
        Func<int, bool> func = i => i > 5; // Lambda Expression
        //Func<int, bool> func = waaaaaa;
        //Func<int, bool> func = delegate(int i) { return i > 5; }; // Anonymous Method CSharp 2.0
        //Func<int, string, bool> func = (int i, string s) => i > 5; // Lambda Expression
        Console.WriteLine(func(3));
        Console.WriteLine(func(7));
    }
}