namespace DogStatsdClient
{
    public interface IStopwatch
    {
        void Start();
        void Stop();
        int ElapsedMilliseconds();
    }
}