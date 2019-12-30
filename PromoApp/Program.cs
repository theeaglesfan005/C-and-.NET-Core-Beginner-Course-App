using System;
using System.Collections.Generic;

namespace PromoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Promoter> promoters = new List<Promoter>() {new XSClubPromoter("Jon", "Jones", 6175555555), new XSClubPromoter("Jim", "Jones", 6185555555), new OmniaClubPromoter("Jane", "Jones", 6195555555)};

            foreach (var promo in promoters)
            {
                promo.Promote();
            }

            List<Writer> writers = new List<Writer>() {new BookWriter("Jim", "Jones"), new BookWriter("Jane", "Jones"), new BlogWriter("Jon", "Jones")};

            foreach (var write in writers)
            {
                write.Write();
            }

            List<IBodyBuilder> bodyBuilders = new List<IBodyBuilder>() {new XSClubPromoter("Jon", "Jones", 6175555555), new XSClubPromoter("Jim", "Jones", 6185555555)};

            foreach (var body in bodyBuilders)
            {
                body.Workout();
            }

            List<IVlogger> vloggers = new List<IVlogger>() {new BookWriter("Jon", "Jones"), new XSClubPromoter("Jim", "Jones", 6185555555)};

            foreach (var vlog in vloggers)
            {
                vlog.Vlog();
            }
        }
    }
}
