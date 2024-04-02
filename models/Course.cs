using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Models;

public class Course
{
    [Key]
    public int Id { get; set; }

    public int StudentId { get; set; }

    [Required]
    [MaxLength(255)]
    public string Name { get; set; }

    [Required]
    [MaxLength(1)]
    public string Grade { get; set; }

    [ForeignKey("StudentId")]
    public Student Student { get; set; }
}