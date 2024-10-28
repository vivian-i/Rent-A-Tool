using Microsoft.EntityFrameworkCore;
using Core.Entities;
using Core.Interfaces;
using Core.Data;

namespace Core.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public ClientRepository(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public async Task<IEnumerable<Client>> GetAllClients()
        {
            var clients = await _dbContext.Clients.ToListAsync();
            return clients;
        }

        public async Task<Client> GetClientById(int id)
        {
            if (id == null || _dbContext.Clients == null)
            {
                return null;
            }

            var client = await _dbContext.Clients
                .Include(c => c.Address)//FK
                .FirstOrDefaultAsync(m => m.Id == id);
            if (client == null)
            {
                return null;
            }

            return client;
        }

        public void AddClient(Client client)
        {
            throw new NotImplementedException();
        }

        public bool DeleteClient(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateClient(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
