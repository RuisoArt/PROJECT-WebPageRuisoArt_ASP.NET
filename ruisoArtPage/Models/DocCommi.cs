using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ruisoArtPage.Models{
    public class DocCommi{
        [Key]
        public int Id { get; set; }
        //******************-----RELATIONSHIP-----************************************************
        public int CommissionId { get; set; }
        [ForeignKey("CommissionId")]
        public Commission Commission { get; set; }

        public int DocId { get; set; }
        [ForeignKey("DocId")]
        public Document Document { get; set; }
        
    }
}