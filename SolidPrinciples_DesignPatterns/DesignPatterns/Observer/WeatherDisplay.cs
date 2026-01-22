namespace DesignPatterns.Observer
{
    public class WeatherDisplay : IObserver
    {
        public void Update(int temperature)
        {
            Console.WriteLine("Weather updated. Temperature: " + temperature);
        }
    }
}
