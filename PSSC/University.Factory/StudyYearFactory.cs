using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Deanship;

namespace Sist.Factory
{
    public class StudyYearFactory
    {

        public static readonly StudyYearFactory Instance = new StudyYearFactory();

        private StudyYearFactory()
        {
        }

        public StudyYear CreateStudyYear()
        {

            var studyYear = new StudyYear();

            return studyYear;
        }
    }
}
