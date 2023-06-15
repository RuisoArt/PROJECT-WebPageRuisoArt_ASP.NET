using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ruisoArtPage.Models{
    
    public class CategoryProduct{
        [Key]
        public int Id { get; set; }
        //******************-----RELATIONSHIP-----************************************************
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }


    }
    
}