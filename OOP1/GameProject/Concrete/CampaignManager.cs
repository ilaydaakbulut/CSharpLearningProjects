using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("added campaign");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("deleted campaign");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("updated campaign");
        }
    }
}
