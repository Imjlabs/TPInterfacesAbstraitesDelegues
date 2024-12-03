namespace TPInterfacesAbstraitesDelegues.Models
{
    public class Disque : Publication
    {
        public Disque(string title, string author) : base(title, author) { }

        public override void PublishDetails()
        {
            Console.WriteLine($"Disque : {Title}, composé par {Author}");
        }
    }
}
