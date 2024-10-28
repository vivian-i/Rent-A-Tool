using Core.Entities;

namespace Core.Interfaces
{
    public interface IEquipmentRepository
    {
        IEnumerable<Equipment> GetAllEquipments();
        Equipment GetEquipmentById(int id);
        void AddEquipment(Equipment eq);
        bool UpdateEquipment(Equipment eq);
        bool DeleteEquipment(int id);
    }
}
