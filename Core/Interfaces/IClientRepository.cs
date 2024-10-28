using Core.Entities;

namespace Core.Interfaces
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> GetAllClients();
        Task<Client> GetClientById(int id);
        void AddClient(Client client);
        bool UpdateClient(Client client);
        bool DeleteClient(int id);
    }
}
