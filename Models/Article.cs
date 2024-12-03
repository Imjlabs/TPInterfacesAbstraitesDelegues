// Classe de base Article
public class Article
{
    public string Title { get; set; }
    public decimal BasePrice { get; set; }

    public Article(string title, decimal basePrice)
    {
        Title = title;
        BasePrice = basePrice;
    }
}

// Classe Livre héritant d'Article
public class Livre : Article
{
    public Livre(string title, decimal basePrice) : base(title, basePrice) { }
}

// Classe Disque héritant d'Article
public class Disque : Article
{
    public Disque(string title, decimal basePrice) : base(title, basePrice) { }
}

// Classe Video héritant d'Article
public class Video : Article
{
    public Video(string title, decimal basePrice) : base(title, basePrice) { }
}
