namespace Merlo.Eda.Infrastructure
{
    public class Command : Message
    {
        public string Name { get; protected set; }
    }
}