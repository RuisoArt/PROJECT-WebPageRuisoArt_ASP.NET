using System.ComponentModel.DataAnnotations;

namespace ruisoArtPage.Models{
    
    public class Provider{
        [Key]
        public int Id { get; set; }
    [Required]
    [Display(Name="Name")]
        public string name { get; set; }
    [Required]
    [StringLength(150, ErrorMessage = "Text so long! 150 char max", MinimumLength = 3 )]
    [Display(Name="Description")]
        public string description { get; set; }
    [Display(Name="IMAGE")]
        public string image { get; set; }
    [Display(Name="Phone")]
        public string phone { get; set; }
    [Display(Name="Link")]
        public string link { get; set; }
    [Display(Name="Email")]
        public string email { get; set; }
    [Display(Name="")]
        public string socialRed0 { get; set; }
    [Display(Name="")]
        public string socialRed1 { get; set; }
    [Display(Name="")]
        public string socialRed2 { get; set; }
    [Display(Name="")]
        public string socialRed3 { get; set; }
    [Display(Name="")]
        public string socialRed4 { get; set; }
    [Display(Name="")]
        public string socialRed5 { get; set; }
    [Display(Name="")]
        public string socialRed6 { get; set; }
    [Display(Name="")]
        public string socialRed7 { get; set; }
    [Display(Name="")]
        public string socialRed8 { get; set; }
    [Display(Name="")]
        public string socialRed9 { get; set; }
    [Display(Name="")]
        public string socialRed10 { get; set; }
    [Display(Name="")]
        public string socialRed11 { get; set; }
    [Display(Name="")]
        public string socialRed12 { get; set; }
    [Display(Name="")]
        public string socialRed13 { get; set; }
    [Display(Name="")]
        public string socialRed14 { get; set; }
    [Display(Name="")]
        public string socialRed15 { get; set; }
    [Display(Name="")]
        public string socialRed16 { get; set; }
    [Display(Name="")]
        public string socialRed17 { get; set; }
    [Display(Name="")]
        public string socialRed18 { get; set; }
    [Display(Name="")]
        public string socialRed19 { get; set; }
        //******************-----RELATIONSHIP-----************************************************
        public List<Banner> Banners { get; set; }
    }
    
}