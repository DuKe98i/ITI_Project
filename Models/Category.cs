using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Test_2.Models
{
    public class Category
    {
        public int Id { get; set; }

        [StringLength(15, MinimumLength = 4, ErrorMessage = "Name Must be between 4 and 15 character.")]
        [Required(ErrorMessage = "Title is Required.")]
        [DisplayName("Category Name")]
        public string Name { get; set; }

        [StringLength(50, MinimumLength = 10, ErrorMessage = "Description Must be more than 10 character.")]
        [Required(ErrorMessage = "Title is Required.")]
        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();

    }
}
