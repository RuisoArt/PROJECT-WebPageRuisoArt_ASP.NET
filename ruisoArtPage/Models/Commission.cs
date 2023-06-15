using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ruisoArtPage.Models{
    public class Commission{
        [Key]
        public int Id { get; set; }

    [Required]
    [Display(Name="Tittle")]
        public string Tittle { get; set; }

    [Required]
    [StringLength(150, ErrorMessage = "Text so long! 150 char max", MinimumLength = 3 )]
    [Display(Name="Description")]
        public string description { get; set; }
    
    [Range(0, 999999.999)]
    [Display(Name="Aprox Price")]
        public double AproxPrice { get; set; }

    [Required]
    [Display(Name="Email")]
        public string Email { get; set;}
    
    [Required]
    [Display(Name="Name")]
        public string PersonName { get; set; }
        
    [Required]
    [Display(Name="Last Name")]
        public string PersonLastName { get; set; }
        
    [Display(Name="Image")]
        public string ImageReference { get; set; }
        //******************-----RELATIONSHIP-----************************************************
        public List<DocCommi> DocCommis { get; set; }

        public List<CategoryCommi> CategoryCommis { get; set; }
        
        /*public int TypeId { get; set; }
        [ForeignKey("TypeId")]
        public MyType MyType { get; set; }*/
    }
    
}