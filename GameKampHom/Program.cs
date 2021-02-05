using System;

namespace GameKampHom
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1999,
                FirstName = "Kader Nur",
                LastName = "Tekin",
                IdentityNumber = 12345
            }
            );
            Console.WriteLine("****************************************************");

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign
            {
                CampaignId = 1,
                CampaignName = "ikinci ürün 1 Tl/Fırsatı Kaçırma",
                CampaignDetail = "Şubat sonu indirimi."
            });
            Console.WriteLine("****************************************************");

            OrderManager orderManager = new OrderManager();
            orderManager.MakeSale(new Products
            {
                ProductId = 1,
                ProductName = "Shoes",
                UnitPrice = 150,
                Stock = 50
            });
        }
    }
}
