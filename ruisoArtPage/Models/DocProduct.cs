using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ruisoArtPage.Models{

    public class DocProduct{
        [Key]
        public int Id { get; set; }
        //******************-----RELATIONSHIP-----************************************************
        public int DocumentId { get; set; }
        [ForeignKey("DocumentId")]
        public Document Document { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
    
}