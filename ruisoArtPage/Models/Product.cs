using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ruisoArtPage.Data.Enum;

namespace ruisoArtPage.Models{

    public class Product{
        [Key]
        public int Id { get; set; }
// Vienen de la antigua tabla Item

//[Required]
[Display(Name = "Name")]
        public string name { get; set; }
//[Required]
[StringLength(150, ErrorMessage = "Text so long! 150 char max", MinimumLength = 3 )]
[Display(Name = "Description")]
        public string description { get; set; }
[Display(Name = "Image")]
        public string image { get; set; }
[Range(0, 999999.999)]
[Display(Name = "Price")]
        public double price { get; set; }
[Range(0,1.0)]
[Display(Name = "Tax")]
        public double tax { get; set; }
[Range(0,100)]
[Display(Name = "Quantity")]
        public int quantity { get; set; }
[Display(Name = "Shopping Way")]
        public string shoppingWay { get; set; }

//ahora si lo que es de product

[DataType(DataType.Date)]
[Display(Name = "Creation Date")]
        public DateTime creationDate { get; set; }
[Display(Name = "Link")]
        public string externalLink {get; set; }
[Display(Name = "NFT")]
        public string nftLink {get; set; }
[Display(Name = "Color")]
        public string color { get; set; }
[Display(Name = "SizeCup")]
        public ListCups sizeCup { get; set; }
[Display(Name = "Model Clothes")]
        public ListClothes modelClothes { get; set; }
[Display(Name = "Size Clothes")]
        public ListSizeClothes sizeClothes { get; set; }
[Display(Name = "Notepad")]
        public ListNotepad sizeNotepad { get; set; }
[Display(Name = "Season")]
        public string season { get; set; }
[Display(Name = "Status")]
        public ListStaus status {  get; set; }
[Display(Name = "Print")]
        public string sizePrint { get; set; }
[Display(Name = "Paper")]
        public ListPaper sizePaper { get; set; }
[Display(Name = "Format")]
        public ListFormatImage formatImage { get; set; }
[Display(Name = "Book Marker")]
        public ListBookMarker sizeBookMarker { get; set; }
[Display(Name = "Dice")]
        public ListDice rolDice { get; set; }
[Display(Name = "Size Dice")]
        public string sizeDice { get; set; }


        //******************-----RELATIONSHIP-----************************************************
        //public List<Document> Documents { get; set; }
        public List<DocProduct> DocProducts { get; set; }
        public List<CategoryProduct> CategoryProducts { get; set; }

        public int ProviderId { get; set; }
        [ForeignKey("ProviderId")]
        public Provider Provider { get; set; }

        /*public int TypeId { get; set; }
        [ForeignKey("TypeId")]
        public MyType MyType { get; set; }*/
    }
    
}