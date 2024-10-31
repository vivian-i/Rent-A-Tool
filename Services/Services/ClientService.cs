using Core.Entities;
using Core.Interfaces;

namespace RentAToolWebApp.Services
{
    public class ClientService //: IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public Task<IEnumerable<Client>> GetAllClients => _clientRepository.GetAllClients();
        public void GetClientById(int id) => _clientRepository.GetClientById(id);
        public void AddClient(Client c) => _clientRepository.AddClient(c);
        public bool DeleteClient(int id) => _clientRepository.DeleteClient(id);

        public async Task<bool> UpdateClient(Client c, int id)
        {
            var existingClient = await _clientRepository.GetClientById(id);
            if (existingClient == null)
            {
                return false;
            }
            else
            {
                existingClient = await UpdateTheClient(existingClient, c);
            }

            return _clientRepository.UpdateClient(existingClient);
        }

        private async Task<Client> UpdateTheClient(Client existingClient, Client updatedClient)
        {
            existingClient.Name = updatedClient.Name;
            existingClient.PhoneNumber = updatedClient.PhoneNumber;
            existingClient.Address = updatedClient.Address;

            return existingClient;
        }
    }
}
