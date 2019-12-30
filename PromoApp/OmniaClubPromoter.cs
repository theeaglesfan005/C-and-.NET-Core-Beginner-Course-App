using System;

public class OmniaClubPromoter : Promoter
{
    public OmniaClubPromoter(string firstName, string lastName, long cellPhone) : base(firstName, lastName, cellPhone)
    {
    }

    protected override void PaidAds()
    {
        Console.WriteLine("I pay to promote on IG.");
    }

    protected override void ShareWithInnerCircle()
    {
        Console.WriteLine("I share with my peeps.");
    }
}