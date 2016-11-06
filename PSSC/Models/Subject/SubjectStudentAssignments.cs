using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Subject
{
    public class SubjectStudentAssignments
    {
        List<Subject> SchoolSubjects { get; set; }

        List<Student.Student> Students { get; set; }
    }
}
