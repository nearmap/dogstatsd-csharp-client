namespace DogStatsdClient
{
    public interface IStatsdUDP
    {
        void Send(string command);
    }
}