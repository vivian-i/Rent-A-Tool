using RentAToolWebApp.Models.Enum;
using RentAToolWebApp.Models;
using System.Data;

namespace RentAToolWebApp.Data
{
    public class DatabaseSeeder
    {
        private readonly DatabaseConnection _conn;

        public DatabaseSeeder(DatabaseConnection conn)
        {
            _conn = conn;
        }

        public void Seed()
        {
            using (IDbConnection conn = _conn.CreateDbConnection())
            {
                //sample insert

                var sql = "INSERT INTO Equipment (Name, Description, SerialNumber, Condition, LastMaintenanceDate, DailyRate, IsAvailable, ImageUrl) " +
                    "VALUES (@Name, @Description, @SerialNumber, @Condition, @LastMaintenanceDate, @DailyRate, @IsAvailable, @ImageUrl)";
                /*conn.Execute(sql,
                    new Equipment()
                    {
                        Name = "Scissor",
                        Description = "Small item",
                        SerialNumber = "SX8723H",
                        Condition = ConditionCategory.Good,
                        LastMaintenanceDate = DateTime.UtcNow,
                        DailyRate = 50.50,
                        IsAvailable = true,
                        ImageUrl = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                    });*/
            }
        }
    }
}
