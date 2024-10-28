using Core.DTOs;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    internal interface IClientService
    {
        Task<IEnumerable<ClientDTO>> GetAllClientsAsync();
        Task<ClientDTO> GetClientByIdAsync(int id);
        Task AddClientAsync(ClientDTO client);
        Task UpdateClientAsync(int id, ClientDTO client);
        Task DeleteClientAsync(int id);
    }
}
