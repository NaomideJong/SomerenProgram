using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SomerenModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class RoomDao : BaseDao
    {
        public List<Room> GetAllRooms()
        {
            // select the query from the Rooms database
            string query = "SELECT roomId, roomType, roomCapacity FROM [Rooms]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Room> ReadTables(DataTable dataTable)
        {
            List<Room> rooms = new List<Room>();

            // check each row of the DataTable
            foreach (DataRow dr in dataTable.Rows)
            {
                Room room = new Room()
                {
                    RoomId = (int)dr["roomId"],
                    RoomType = (string)dr["roomType"],
                    RoomCapacity = (int)dr["roomCapacity"]
                };
                // add the room to the list
                rooms.Add(room);
            }
            return rooms;
        }
    }
}
