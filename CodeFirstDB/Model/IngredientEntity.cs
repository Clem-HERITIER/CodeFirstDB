using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Model
{
    [Table("Ingredients")]
    public class IngredientEntity
    {
        [Key]
        public Guid IngredientId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

    }
}
