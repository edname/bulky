using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Kategorijos pavadinimas")]
        public string Name { get; set; }
        [DisplayName("Atvaizdavimo sekos numeris")]
        public int DisplayOrder { get; set; }
    }
}
