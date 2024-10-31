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

        public async Task<Client> GetClientById(Guid id)
        {
            if (id == null || _dbContext.Clients == null)
            {
                return null;
            }

            var client = await _dbContext.Clients
                .Where(e => e.Id == id)
                .FirstOrDefaultAsync();
            if (client == null)
            {
                return null;
            }

            return client;
        }

        public void AddClient(Client client)
        {
            _dbContext.Clients.AddAsync(client);
            _dbContext.SaveChangesAsync();
        }

        public async Task<bool> DeleteClientById(Guid id)
        {
            bool isDeleted = false;

            var theClient = _dbContext.Clients.FirstOrDefault(e => e.Id == id);
            _dbContext.Clients.RemoveRange(theClient);
            await _dbContext.SaveChangesAsync();
            isDeleted = true;

            return isDeleted;
        }

        public async Task UpdateClient(Client client)
        {
            var existingClient = _dbContext.Clients.FirstOrDefaultAsync(e => e.Id == client.Id);
            if(existingClient != null)
            {
                throw new KeyNotFoundException($"Client with ID {client.Id} not found.");
            }

            //existingClient.n

            //existingClient.

            await _dbContext.SaveChangesAsync();
        }

        public Task<Client> GetClientById(int id)
        {
            throw new NotImplementedException();
        }

        bool IClientRepository.UpdateClient(Client client)
        {
            throw new NotImplementedException();
        }

        public bool DeleteClient(int id)
        {
            throw new NotImplementedException();
        }
    }
}
