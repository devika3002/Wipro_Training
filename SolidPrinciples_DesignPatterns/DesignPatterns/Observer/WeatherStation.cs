namespace DesignPatterns.Observer
{
    public class WeatherStation
    {
        private List<IObserver> observers = new List<IObserver>();
        private int temperature;

        public void Register(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void SetTemperature(int temp)
        {
            temperature = temp;
            NotifyObservers();
        }

        private void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature);
            }
        }
    }
}
