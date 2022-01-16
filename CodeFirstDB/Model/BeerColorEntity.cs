using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDB.Model
{
    [Table("BeerColors")]
    public class BeerColorEntity
    {
        [Key]
        public Guid ColorID { get; set; }

        public string Name { get; set; }
    }
}
