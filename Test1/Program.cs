// See https://aka.ms/new-console-template for more information

using System;
using System.Diagnostics;

class Test2
{
    public Test2(int i)
    {
        this.i = i;
    }

    [Conditional("DEBUG")]
    public void VerifyState()
    {
        if (i != 0)
            Console.WriteLine("Bad State");

        Debug.Assert(i == 0, "Bad State");

    }

    int i = 0;
}

class Test
{
    public static void Main()
    {
        Debug.Listeners.Clear();
        Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
        Test2 c = new Test2(1);
        c.VerifyState();
        Console.WriteLine("test");
    }
}