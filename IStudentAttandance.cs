using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubjectAtendenceProject
{
    /**
     * Interface Name : IStudentAttandance
     * Objective : Contain all methods definations
     * @author : Ritika jaiswal
     * Date : 20\04\22
     **/
    public interface IStudentAttandance
    {
        public List<SubjectAttendance> getSubjectAttendances(List<StudentData> list);
        public MaxAttendanceStudent getMaxAttendanceStudents(List<MaxAttendanceStudent> totalAttandanceList);
        public MaxAttendanceStudent getMinAttendanceStudents(List<MaxAttendanceStudent> totalAttandanceList);
        public List<StudentHighestAttendance> getStudentHighestAttendance(List<StudentData> list);
        public List<StudentOrderAttendance> getStudentOrderAttendances(List<StudentData> list);
        public List<MaxAttendanceStudent> getTotalAttendance(List<StudentData> studentDetailList);
    }
}
