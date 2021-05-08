using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class SaleManager : ISaleService
    {
        public void Add(Member member, Game game, Campaign campaign)
        {
            Console.WriteLine("Added game : Game " + game.GameName + "\nPerson : " + member.FirstName + " " + member.LastName + "\nCampaign : " + campaign.CampaignName);
        }

        public void Delete(Member member, Game game, Campaign campaign)
        {
            Console.WriteLine("Deleted game : Game " + game.GameName + "\nPerson : " + member.FirstName + " " + member.LastName + "\nCampaign : " + campaign.CampaignName);
        }

        public void Update(Member member, Game game, Campaign campaign)
        {
            Console.WriteLine("Updated game : Game " + game.GameName + "\nPerson : " + member.FirstName + " " + member.LastName + "\nCampaign : " + campaign.CampaignName);
        }
    }
}
