using System;
using System.Collections.Generic;
using System.Text;

namespace GameKampHom
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign added"); ;
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign deleted"); ;
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign updated"); ;
        }
    }
}
