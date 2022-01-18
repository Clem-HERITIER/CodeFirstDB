using CodeFirstDB.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Model
{
    [Table("Brewerys")]
    public class BreweryEntity
    {
        [Key]
        //Primary Key
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public CountryEntity Country { get; set; }
    }
}
