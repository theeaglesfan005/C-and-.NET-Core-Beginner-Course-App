using System;

public class XSClubPromoter : Promoter, IBodyBuilder, IVlogger
{
    public XSClubPromoter(string firstName, string lastName, long cellPhone) : base(firstName, lastName, cellPhone)
    {
    }

    public void Vlog()
    {
        Console.WriteLine("I use 4k cameras to vlog.");
    }

    public void Workout()
    {
        Console.WriteLine("I workout at the gym.");
    }

    protected override void PaidAds()
    {
        Console.WriteLine("I pay to promote on Facebook.");
    }

    protected override void ShareWithInnerCircle()
    {
        Console.WriteLine("I share with my dudes.");
    }
}