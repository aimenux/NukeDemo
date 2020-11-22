namespace Lib
{
    public class DummyService : IDummyService
    {
        public string GetStartingMessage()
        {
            return "App is starting.";
        }

        public string GetStoppingMessage()
        {
            return "App is stopping.";
        }
    }
}
