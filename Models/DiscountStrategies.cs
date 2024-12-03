using TPInterfacesAbstraitesDelegues.Models;

namespace TPInterfacesAbstraitesDelegues.Services
{
    public static class DiscountStrategies
    {
        // Remise fixe
        public static decimal FixedDiscount(Article article)
        {
            return 5m; // Une remise fixe de 5 €
        }

        // Remise en pourcentage
        public static decimal PercentageDiscount(Article article)
        {
            return article.BasePrice * 0.10m; // 10% du prix de base
        }

        // Remise spécifique selon le type
        public static decimal TypeSpecificDiscount(Article article)
        {
            if (article is Livre)
                return 3m; // 3 € pour les livres
            if (article is Disque)
                return 4m; // 4 € pour les disques
            if (article is Video)
                return 5m; // 5 € pour les vidéos

            return 0m; // Pas de remise pour les autres types
        }
    }
}
