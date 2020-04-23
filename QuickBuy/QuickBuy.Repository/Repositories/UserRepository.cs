using QuickBuy.Domain.Contract;
using QuickBuy.Domain.Entities;

namespace QuickBuy.Repository.Repositories
{
    public class UserRepository : BaseRepository<User>, IUsuarioRepository 
    {
        public UserRepository()
        {

        }

    }
}
