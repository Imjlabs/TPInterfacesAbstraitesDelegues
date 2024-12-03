namespace TPInterfacesAbstraitesDelegues.Models
{
    public abstract class Publication
    {
        public string Title { get; set; }
        public string Author { get; set; }

        protected Publication(string title, string author)
        {
            Title = title;
            Author = author;
        }

        // Méthode abstraite à implémenter dans les classes dérivées
        public abstract void PublishDetails();
    }
}
