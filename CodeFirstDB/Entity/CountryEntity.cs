using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Model
{
    [Table("Countrys")]
    public class CountryEntity
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

    }
}
