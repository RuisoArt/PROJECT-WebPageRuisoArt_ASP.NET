using System.ComponentModel.DataAnnotations;
using ruisoArtPage.Data.Enum;

namespace ruisoArtPage.Models{
    public class Category{
        [Key]
        public int Id { get; set; }
    [Required]
        public ListCategory Name { get; set; }
        //******************-----RELATIONSHIP-----************************************************
        public List<CategoryProduct> CategoryProducts { get; set; }
        public List<CategoryCommi> CategoryCommis { get; set; }
    }
    
}