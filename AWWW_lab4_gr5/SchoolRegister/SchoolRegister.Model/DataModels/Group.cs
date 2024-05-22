using System.ComponentModel.DataAnnotations;

namespace SchoolRegister.Model.DataModels;
public class Group
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public virtual IList<Student> Students { get; set; }
    public virtual IList<SubjectGroup> SubjectGroups { get; set; }
    public Group() { }
}
