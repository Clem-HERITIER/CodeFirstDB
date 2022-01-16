using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Model
{
    [Table("BeerIngredients")]
    public class BeerIngredientEntity
    {
        [Key]
        public Guid Id { get; set; }

        public Guid BeerId { get; set; }

        public Guid IngredientId { get; set; }
    }
}
