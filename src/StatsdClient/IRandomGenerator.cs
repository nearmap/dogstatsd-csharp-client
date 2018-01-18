namespace DogStatsdClient
{
    public interface IRandomGenerator
    {
        bool ShouldSend(double sampleRate);

    }
}