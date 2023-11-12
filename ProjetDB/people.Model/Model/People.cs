using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.Model.Model
{
    [Table("People")]
    public class People
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [MaxLength(50)]
        public string? Name { get; set; }
        [MaxLength(50)]
        public string? City { get; set; }

        public int Age { get; set; }
    }
}
