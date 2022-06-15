using Microsoft.EntityFrameworkCore;

namespace OnlinePharmacy.Models;

public static class SeedData
{
    public static void EnsurePopulated(IApplicationBuilder app)
    {
        StoreDbContext context = app.ApplicationServices
            .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

        if (context.Database.GetPendingMigrations().Any())
        {
            context.Database.Migrate();
        }

        if (!context.Products.Any())
        {
            context.Products.AddRange
            (
                new Product
                {
                    Name = "Paracet 500mg tabletter 20stk",
                    Description = "Korttidsbehandling av milde til moderate smerter og feber",
                    Category = "Smertestillende",
                    Price = 29.90m
                },
                new Product
                {
                    Name = "Ibux 200mg kapsler 20stk",
                    Description = "Ved feber og ved kortvarige, lette til moderate smerter",
                    Category = "Smertestillende",
                    Price = 49
                },
                new Product
                {
                    Name = "Nycoplus Høykonsentrert omega-3 500mg kapsler 120stk",
                    Description = "Daglig tilskudd av høykonsentrert omega-3 i små kapsler",
                    Category = "Kosttilskudd",
                    Price = 214.90m
                },
                new Product
                {
                    Name = "Nycoplus Multi tabletter 200stk",
                    Description = "Sikrer kroppens daglige inntak av viktige vitaminer og mineraler",
                    Category = "Kosttilskudd",
                    Price = 134
                },
                new Product
                {
                    Name = "Gevita Sink & vitamin C tabletter 120stk",
                    Description = "Bidrar til immunforsvarets normale funksjon og ivaretar huden",
                    Category = "Kosttilskudd",
                    Price = 97.50m
                },
                new Product
                {
                    Name = "A-Derma Exomega Control lotion 400ml",
                    Description = "Fuktighetsgivende lotion til tørr hud med tendens til atopi",
                    Category = "Hudpleie",
                    Price = 299
                },
                new Product
                {
                    Name = "La Roche-Posay Lipikar Balm Light AP+M 400ml",
                    Description = "Beroligende, styrkende og kløestillende krem til tørr og irritert hud",
                    Category = "Hudpleie",
                    Price = 389
                },
                new Product
                {
                    Name = "Bepanthen salve 30g",
                    Description = "Pleier og forebygger tørr, irritert hud og røde barnestumper",
                    Category = "Hudpleie",
                    Price = 64
                },
                new Product
                {
                    Name = "Canoderm 5% krem 100g",
                    Description = "Behandler tørr hud og forebygger tilbakefall av atopisk eksem",
                    Category = "Hudpleie",
                    Price = 79
                }
            );

            context.SaveChanges();
        }
    }
}