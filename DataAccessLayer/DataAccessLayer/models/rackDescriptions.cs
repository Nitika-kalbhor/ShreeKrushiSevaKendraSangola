using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.models
{
    public class rackDescriptions: commonModels
    {
        public int rackDescriptionId { get; set; }
        public int rackDetailId { get; set; }
        public string rackDescription { get; set; }
    }
}
