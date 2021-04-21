using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.models
{
    public class rackDetails: commonModels
    {
        public int rackDetailId { get; set; }
        public int warehouseId { get; set; }      
        public string rackName { get; set; }
        public string rackNo { get; set; }
        public string warehouseName { get; set; }
        public int roomId { get; set; }
        public string roomNo { get; set; }
    }
    public class RackSelfBySearch
    {
        public int rackDetailId { get; set; }
        public string rackNo { get; set; }
    }
}
