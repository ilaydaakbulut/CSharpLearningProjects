using System;
using GameProject.Abstract;
using GameProject.Adapter;
using GameProject.Concrete;
using GameProject.Entities;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MemberManager memberManager1 = new MemberManager();
            Member member1 = new Member{FirstName = "İlayda",LastName = "Akbulut",DateOfBirth = new DateTime(1997),Id = 1, NationalityId = "123456789" }; 
            memberManager1.Save(member1);

            GameManager gameManager1 = new GameManager();
            GameManager gameManager2 = new GameManager();
            Game game1 = new Game { Id = 1, GameName = "AA", GameType = "X" };
            Game game2 = new Game { Id = 2, GameName = "BB", GameType = "Y" };

            gameManager1.Add(game1);
            gameManager2.Add(game2);

            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign = new Campaign { Id = 1, CampaignName = "season sale", CampaignType = "%50" };
            campaignManager.Add(campaign);

            SaleManager saleManager1 = new SaleManager();
            saleManager1.Add(member1, game1, campaign);

        }
    }
}
