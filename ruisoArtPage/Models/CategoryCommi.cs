using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ruisoArtPage.Models{
    public class CategoryCommi{
        [Key]
        public int Id { get; set; }
        //******************-----RELATIONSHIP-----************************************************}
        public int CommissionId { get; set; }
        [ForeignKey("CommissionId")]
        public Commission Commission { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
    
}