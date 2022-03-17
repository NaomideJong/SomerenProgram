using System;
using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class RoomService
    {
        RoomDao roomdb;

        public RoomService()
        {
            roomdb = new RoomDao();
        }

        public List<Room> GetRooms()
        {
            // return the list of rooms
            List<Room> rooms = roomdb.GetAllRooms();
            return rooms;
        }
    }
}
