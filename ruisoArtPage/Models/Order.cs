using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ruisoArtPage.Models{
    public class Order{
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public DateTime CreateDate { get; set; }

        //------------------------------Relationships----------------------------------
        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; }

        public List<OrderItem> Items { get; set; }

        //------------------------------todo Order Items----------------------------------
        
    }
}