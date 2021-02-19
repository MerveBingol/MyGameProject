using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    class GameSaleManager : IGameSaleService
    {

        ICampaignService _campaignService;

        public GameSaleManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        public void GetGameSale(GameSale gameSale)
        {
            Console.WriteLine(" Oyunu satıın aldıı");
        }

      
    }
}
