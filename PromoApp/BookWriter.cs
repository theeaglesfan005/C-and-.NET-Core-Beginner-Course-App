using System;

public class BookWriter : Writer
{
    public BookWriter(string first, string last) : base(first, last)
    {
    }

    public override void Vlog()
    {
        Console.WriteLine("I vlog using my 2019 16\" MacBook Pro.");
    }
    
    public override void Write()
    {
        Console.WriteLine("I write books.");
    }
}