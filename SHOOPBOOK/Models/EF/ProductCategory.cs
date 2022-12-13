using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SHOOPBOOK.Models.EF
{
    [Table("tb_ProductCategory")]
    public class ProductCategory:Common
    {
        public ProductCategory()
        {
            this.Product = new HashSet<Product>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Tên không được để trống")]
        [StringLength(150)]
        public string Tilte { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public string SeoTilte { get; set; }
        public string SeoDescription { get; set; }
        public string SeoKeywords { get; set; }
        public ICollection<Product> Product{ get;}
    }
}