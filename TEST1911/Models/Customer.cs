using LinqToDB.Mapping;
using System.ComponentModel.DataAnnotations;

namespace TEST1911.Models
{
    [Table(Name = "CUSTOMERS")]
    public class Customer
    {
        [Column(Name = "ID"), PrimaryKey, Identity]
        public int Id { get; set; }

        [Column(Name = "NAME"), NotNull]
        public string Name { get; set; }

        [Column(Name = "ADDRESS"), NotNull]
        public string Address { get; set; }
    }
}
