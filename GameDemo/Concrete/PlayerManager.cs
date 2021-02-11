using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class PlayerManager : BasePlayerManager
    {
        private IPlayerCheckService _playerCheckService;

        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public override void Add(Player player)
        {
            if (_playerCheckService.CheckIfRealPerson(player))
            {
                base.Add(player);
            }
            else
            {
                throw new Exception("Not a valid person!!!");
            }

        }

        public void Delete(Player player)
        {
            Console.WriteLine("Player is deleted with successfully : " + player.FirstName);
        }

        public void Update(Player player)
        {
            Console.WriteLine("Player is updated with successfully : " + player.FirstName);
        }



    }
}
