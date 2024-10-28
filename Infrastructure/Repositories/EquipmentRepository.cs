using Core.Data;
using Core.Entities;
using Core.Interfaces;

namespace Core.Repositories
{
    public class EquipmentRepository : IEquipmentRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public EquipmentRepository(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public void AddEquipment(Equipment eq)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEquipment(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Equipment> GetAllEquipments()
        {
            throw new NotImplementedException();
        }

        public Equipment GetEquipmentById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEquipment(Equipment eq)
        {
            throw new NotImplementedException();
        }
    }
}
