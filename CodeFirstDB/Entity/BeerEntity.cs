using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Model
{
    [Table("Beers")]
    public class BeerEntity
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public float Ibu { get; set; }

        public float Degree { get; set; }

        public BreweryEntity Brewery { get; set; }

        public BeerStyleEntity Style { get; set; }

        public BeerColorEntity Color { get; set; }

        // Demander conceils a un formateur 
        /*
        public ICollection<IngredientEntity> Ingredients { get; set; }
        */
    }
}
