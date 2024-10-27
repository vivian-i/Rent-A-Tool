using RentAToolWebApp.Data;
using RentAToolWebApp.Models;

namespace RentAToolWebApp.Repositories
{
    public class EquipmentRepository : IEquipmentRepository
    {
        private readonly DatabaseConnection _dbConn;

        public EquipmentRepository(DatabaseConnection dbConn)
        {
            _dbConn = dbConn;
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
