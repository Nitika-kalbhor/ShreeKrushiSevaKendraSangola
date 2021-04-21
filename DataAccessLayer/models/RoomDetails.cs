using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DataAccessLayer.models
{
 public   class RoomDetails:commonModels
    {
        public int roomId { get; set; }
        public int warehouseId { get; set; }
        public string warehouseName { get; set; }
        public string roomNo { get; set; }
     
    }
    public class roomDetailsBy
    {
        public int roomId { get; set; }
        public string roomNo { get; set; }
    }
}
