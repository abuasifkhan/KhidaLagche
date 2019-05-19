namespace KhidhaLagche.Services
{
    public interface IGreeter
    {
        string GetGreetingMessage();
    }

    public class Greeter : IGreeter
    {
        public string GetGreetingMessage()
        {
            return "Thousand blessings from Asif!";
        }
    }
}