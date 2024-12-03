namespace TPInterfacesAbstraitesDelegues.Models
{
    public class Livre : Publication
    {
        public Livre(string title, string author) : base(title, author) { }

        public override void PublishDetails()
        {
            Console.WriteLine($"Livre : {Title}, écrit par {Author}");
        }
    }
}
