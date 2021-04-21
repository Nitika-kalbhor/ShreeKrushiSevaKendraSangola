using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.models
{
    public class Warehouse: commonModels
    {
        public long employeeId { get; set; }
        public int warehouseId { get; set; }
        public string warehouseName { get; set; }
        public string location { get; set; }      
        public string contactNo { get; set; }
    }
}
