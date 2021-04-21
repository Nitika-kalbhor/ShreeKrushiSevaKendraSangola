using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DataAccessLayer.models
{
    public class ItemDetails:commonModels
    {
        public long itemId { get; set; }
        public int companyId { get; set; }
        public string batchNo { get; set; }
        public string companyName { get; set; }
        public string productCode { get; set; }
        public string HNSCode { get; set; }
        public double IGST { get; set; }
        public double CGST { get; set; }
        public double SGST { get; set; }
          public string rackNo { get; set; }
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public string itemName { get; set; }
        public double reorderLevel { get; set; }     
        public string color { get; set; }     
        public string weightIn { get; set; }
        public string unitBy { get; set; }
        public double openingStock { get; set; }
        public double price { get; set; }
        public double vat { get; set; }
        public DateTime MFD_Date { get; set; }
        public DateTime expireDate { get; set; }

        //Stock Details
        public long StockId { get; set; }     
        public double purchaseStock { get; set; }
        public double purchaseReturnStock { get; set; }
        public double saleStock { get; set; }
        public double saleReturnStock { get; set; }
        public double stockIn { get; set; }
        public double stockOut { get; set; }
        public double currentStock { get; set; }     
        public double purchaseRate { get; set; }
        public double salesCashRate { get; set; }
        public double salesCreditRate { get; set; }
        public double wholeSalesCashRate { get; set; }
        public double wholeSalesCreditRate { get; set; }
        public string mainCategory { get; set; }
        public string godownDetails { get; set; }
        public Boolean isExpiryApplicable { get; set; }
        public Boolean isDelete { get; set; }
    }

    public class ItemNameBy
    {
        public long itemId { get; set; }
        public string itemName { get; set; }
    }

    public class StockBatchNoById
    {
        public long StockId { get; set; }
        public string batchNo { get; set; }
    }
}
