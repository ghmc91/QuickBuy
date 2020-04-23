using QuickBuy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickBuy.Repository.Repositories
{
    public class Cliente
    {
        public Cliente()
        {
            var userRepository = new UserRepository();
            var produto = new Produto();
            var user = new User();
            userRepository.Adicionar(user);
        }

    }
}
