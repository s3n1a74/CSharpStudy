using SerializePractice;
using System.Text.Json;
using System.Xml.Serialization;
class Program
{
    public static async Task Main(string[] args)
    {
        //todo: сериализация в xml; json должна быть в отдельном классе, с учётом ооп
        GasAppliance kolonka = new GasAppliance(new Manufacturer("Lvov"), ApplianceType.Geyser);
        GasAppliance plita = new GasAppliance(new Manufacturer("Gorenje"), ApplianceType.GasStove);
        GasAppliance kotel = new GasAppliance(new Manufacturer("APOK"), ApplianceType.GasBoiler);

        Employee stary = new Employee("Danil", 25, new List<GasAppliance> { kolonka, kotel, plita });
        Employee me = new Employee("Senya", 24, new List<GasAppliance> { kolonka, plita, kotel });
        Employee student = new Employee("Random name", 20, new List<GasAppliance> { plita });

        Employee[] employees = { stary, me, student };

        using (FileStream fs = new FileStream("employees.json", FileMode.OpenOrCreate))
        {
            await JsonSerializer.SerializeAsync(fs, employees);
        }

        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee[]));

        using (FileStream fs = new FileStream("employees.xml", FileMode.OpenOrCreate))
        {
            xmlSerializer.Serialize(fs, employees);
        }

        Console.WriteLine("Сериализация завершена.");
    }
}
