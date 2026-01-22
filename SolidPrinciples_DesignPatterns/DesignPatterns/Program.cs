using DesignPatterns.Singleton;
using DesignPatterns.Factory;
using DesignPatterns.Observer;

class Program
{
    static void Main()
    {
        // SINGLETON
        Console.WriteLine("Singleton Pattern:");
        Logger logger = Logger.Instance;
        logger.Log("Application started");

        // FACTORY
        Console.WriteLine("\nFactory Pattern:");
        IDocument pdf = DocumentFactory.CreateDocument("PDF");
        pdf.Open();

        IDocument word = DocumentFactory.CreateDocument("WORD");
        word.Open();

        // OBSERVER
        Console.WriteLine("\nObserver Pattern:");
        WeatherStation station = new WeatherStation();
        WeatherDisplay display = new WeatherDisplay();

        station.Register(display);
        station.SetTemperature(30);
        station.SetTemperature(35);

        Console.ReadLine();
    }
}
