using System;

public class BlogWriter : Writer
{
    public BlogWriter(string first, string last) : base(first, last)
    {
    }

    public override void Vlog()
    {
        Console.WriteLine("I vlog using an iPhone 11 Pro Max.");
    }

    public override void Write()
    {
        Console.WriteLine("I write blogs and know things.");
    }
}