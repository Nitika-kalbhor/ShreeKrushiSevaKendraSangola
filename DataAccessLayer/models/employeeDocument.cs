using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DataAccessLayer.models
{
    public class employeeDocument: commonModels
    {
        public long employeeDocumentId  { get; set; }
        public string documentType { get; set; }
        public Byte documentImage { get; set; }
    }
}
