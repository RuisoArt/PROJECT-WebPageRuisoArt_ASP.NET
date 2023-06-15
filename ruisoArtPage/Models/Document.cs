using System.ComponentModel.DataAnnotations;

namespace ruisoArtPage.Models{
    public class Document{
        [Key]
        public int Id { get; set; }
    [Required]
    [Display(Name = "Name")]
        public string Name { get; set; }
    [Required]
    [Display(Name = "Link")]
        public string Link { get; set; }
        //******************-----RELATIONSHIP-----************************************************
        public List<DocProduct> DocProducts { get; set; }
    }    
}