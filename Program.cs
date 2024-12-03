using System;
using System.Collections.Generic;
using TPInterfacesAbstraitesDelegues.Models;
using TPInterfacesAbstraitesDelegues.Delegates;
using TPInterfacesAbstraitesDelegues.Services;

namespace TPInterfacesAbstraitesDelegues
{
    class Program
    {
        static void Main()
        {
            // Création de la liste d'articles
            var articles = new List<Article>
            {
                new Livre("Les Misérables", 20m),
                new Disque("Abbey Road", 25m),
                new Video("Inception", 30m)
            };

            // Définir les stratégies de remise
            DiscountStrategy fixedDiscount = DiscountStrategies.FixedDiscount;
            DiscountStrategy percentageDiscount = DiscountStrategies.PercentageDiscount;
            DiscountStrategy typeSpecificDiscount = DiscountStrategies.TypeSpecificDiscount;

            // Afficher les remises pour chaque article
            Console.WriteLine("Application des remises sur les articles :");
            foreach (var article in articles)
            {
                Console.WriteLine($"Article : {article.Title}");
                Console.WriteLine($"  Prix initial : {article.BasePrice:C}");
                Console.WriteLine($"  Remise fixe : {fixedDiscount(article):C}");
                Console.WriteLine($"  Remise pourcentage : {percentageDiscount(article):C}");
                Console.WriteLine($"  Remise spécifique : {typeSpecificDiscount(article):C}");
                Console.WriteLine($"  Prix après remise spécifique : {article.BasePrice - typeSpecificDiscount(article):C}");
                Console.WriteLine();
            }
        }
    }
}
