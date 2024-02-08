using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsManagement.Models
{
    [Table("Categories")]
    public class Category
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }
    }
}
