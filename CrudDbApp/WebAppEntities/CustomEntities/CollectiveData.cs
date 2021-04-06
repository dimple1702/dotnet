using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebAppEntities.CustomEntities
{
    public class CollectiveData
    {
        [Key]
        public long StudentId { get; set; }
        public string StudentFname { get; set; }
        public string StudentLname { get; set; }
        public string StudentEmail { get; set; }
        public string TeacherName { get; set; }
        public string TeacherEmail { get; set; }
        public string DeptName { get; set; }
        public string Address { get; set; }
    }
}
