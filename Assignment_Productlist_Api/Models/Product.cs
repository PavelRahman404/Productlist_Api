using System.ComponentModel.DataAnnotations;

namespace Assignment_Productlist_Api.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string ProductName { get; set; }

        [StringLength(100)]
        public string CategoryName { get; set; }

        public double UnitPrice { get; set; }

        public int StockQty { get; set; }
    }
}
