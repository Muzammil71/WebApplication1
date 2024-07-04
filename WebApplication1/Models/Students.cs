using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Students
    {
        [Key]
        public int Id { get; set; }
        [Column("StudentName", TypeName = "varchar(100)")]
        public string Name { get; set; }
        [Column("FatherName", TypeName = "varchar(100)")]
        public string FatherName { get; set; }
        [Column("Age", TypeName = "Int")]
        public int Age { get; set; }
        [Column("DOB", TypeName = "Int")]
        public int Birthday { get; set; }
    }
}
