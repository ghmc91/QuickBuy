

using System.Collections;
using System.Collections.Generic;

namespace QuickBuy.Domain.Entities
{
    class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }
    }
}
