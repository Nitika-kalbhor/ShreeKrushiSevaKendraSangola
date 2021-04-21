using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.models
{
    public class ItemDetails:commonModels
    {
        public long itemId { get; set; }
        public int subCategoryId { get; set; }
        public string subCategoryName { get; set; }
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public string itemName { get; set; }
        public double reorderLevel { get; set; }
        public int warehouseId { get; set; }
        public string warehouseName { get; set; }
        public double weight { get; set; }
        public string weightIn { get; set; }
        public string sizeNo { get; set; }
        public double openingStock { get; set; }
        public double price { get; set; }
        public double vat { get; set; }

        //Stock Details
        public long StockId { get; set; }     
        public string batchNo { get; set; }
        public double roomId { get; set; }
        public string roomNo { get; set; }
        public int rackDetailsId { get; set; }
        public string rackNo { get; set; }
        public double currentStock { get; set; }
        public double weightPerQuantity { get; set; }
        public double purchaseRate { get; set; }
        public double salesCashRate { get; set; }
        public double salesCreditRate { get; set; }
        public double wholeSalesCashRate { get; set; }
        public double wholeSalesCreditRate { get; set; }
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
