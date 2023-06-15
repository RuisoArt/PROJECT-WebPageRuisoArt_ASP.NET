using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ruisoArtPage.Models{

    public class Banner{
        [Key]
        public int Id { get; set; }
[Required]
[Display(Name = "Name")]
        public string Name { get; set; }
[StringLength(150, ErrorMessage = "Text so long! 150 char max", MinimumLength = 3 )]
[Display(Name = "Description")]
        public string Description { get; set; }
[Display(Name = "Size")]
        public string size { get; set; }
[Display(Name = "Image")]
        public string image { get; set; }
[Display(Name = "Link")]
        public string link { get; set; }
        //******************-----RELATIONSHIP-----************************************************
        public int ProviderId { get; set; }
        [ForeignKey("ProviderId")]
        public Provider Provider { get; set; }

    }
    
}