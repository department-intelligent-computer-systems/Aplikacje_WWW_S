using System.ComponentModel.DataAnnotations;
namespace SchoolRegister.ViewModels.VM;
public class AddGradeToStudentVm
{
    [Required]
    public int StudentId { get; set; }
    [Required]
    public required int SubjectId { get; set; }
    [Required]
    public required GradeScale GradeValue { get; set; }
    [Required]
    public int TeacherId { get; set; }
}