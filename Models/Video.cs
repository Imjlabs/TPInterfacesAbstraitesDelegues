namespace TPInterfacesAbstraitesDelegues.Models
{
    public class Video : Publication
    {
        public Video(string title, string author) : base(title, author) { }

        public override void PublishDetails()
        {
            Console.WriteLine($"Vidéo : {Title}, réalisée par {Author}");
        }
    }
}
