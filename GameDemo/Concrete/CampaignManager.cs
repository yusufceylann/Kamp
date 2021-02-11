using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class CampaignManager
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign is added with succesfully" + campaign.Name);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign is deleted with succesfully" + campaign.Name);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign is updated with succesfully" + campaign.Name);
        }
    }
}
