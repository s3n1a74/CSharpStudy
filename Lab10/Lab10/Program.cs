using Lab10;

class Program
{
    static void Main(string[] args)
    {
        //first/second task
        FlatInCenter flatInCenter = new FlatInCenter(300, 36, "Центр");
        var a = flatInCenter.ToString();
        Console.WriteLine(a);

        //third task
        DateOnly dateOnly = new DateOnly(2014,5,5);
        DateOnly dateOnly1 = new DateOnly(2019, 6, 6);
        DateOnly dateOnly2 = new DateOnly(2024, 3, 24);
        FreeSoftware freeSoftware = new FreeSoftware("Windows", "Microsoft");
        FreeSoftware freeSoftware1 = new FreeSoftware("Driver", "Microsoft");
        SharewareSoftware sharewareSoftware = new SharewareSoftware("a", "b", dateOnly, 70, dateOnly2);
        SharewareSoftware sharewareSoftware1 = new SharewareSoftware("C", "ass", dateOnly1, 50, dateOnly2);
        CommercialSoftware commerc = new CommercialSoftware("sad", "wdwd", 250, dateOnly, dateOnly2);
        CommercialSoftware commercialSoftware = new CommercialSoftware("sdwdw", "wdwdw", 400, dateOnly1 , dateOnly2);
        Software[] softwares = new Software[6];
        softwares[0] = freeSoftware;
        softwares[1] = freeSoftware1;
        softwares[2] = sharewareSoftware;
        softwares[3] = sharewareSoftware1;
        softwares[4] = commerc;
        softwares[5] = commercialSoftware;
        foreach(Software software in softwares)
        {
            Console.WriteLine(software.ToString());
        }

        foreach (Software software in softwares)
        {
            Console.WriteLine(software.IsActual());
        }
    }
}