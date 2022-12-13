using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SHOOPBOOK.Models.EF
{
    [Table("tb_Category")]
    public class Category:Common
    {
        public Category() 
        {
            this.News = new HashSet<News>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Tilte { get; set; }
        public string Description { get; set; }
        public string SeoTilte { get; set; }
        public string SeoDescription { get; set; }
        public string SeoKeywords { get; set; }
        public int Position { get; set; }
        public ICollection<News> News { get; set; }
        public ICollection<Posts> Posts { get; set; }
    }
}