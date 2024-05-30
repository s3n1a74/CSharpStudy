using SerializePractice;
class Program
{
    public static void Main(string[] args)
    {
        GasAppliance kolonka = new GasAppliance(new Manufacturer("Lvov"), ApplianceType.Geyser);
        GasAppliance plita = new GasAppliance(new Manufacturer("Gorenje"), ApplianceType.GasStove);
        GasAppliance kotel = new GasAppliance(new Manufacturer("APOK"), ApplianceType.GasBoiler);

        Employee stary = new Employee("Danil", 25, new List<GasAppliance> { kolonka, kotel, plita });
        Employee me = new Employee("Senya", 24, new List<GasAppliance> { kolonka, plita, kotel });
        Employee student = new Employee("Random name", 20, new List<GasAppliance> { plita });

        Employee[] employees = { stary, me, student };

        IObjectSerialize objectSerialize = new SerializeToJson("serialize.json", employees);
        objectSerialize.ObjectSerialize();
        IObjectSerialize objectSerialize1 = new SerializeToXml("serialize.xml", employees);
        objectSerialize1.ObjectSerialize();
    }

}