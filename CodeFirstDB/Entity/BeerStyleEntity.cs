using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Model
{
    [Table("BeerStyles")]
    public class BeerStyleEntity
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
