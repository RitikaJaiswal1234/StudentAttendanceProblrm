using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubjectAtendenceProject
{
    /**
     * class Name : IStudentAttandance
     * Objective : Implement of all methods which are access in Interface
     * @author : Ritika jaiswal
     * Date : 20\04\22
     **/
    public class StudentAttandanceImpl : IStudentAttandance
    {
        /**
         * Method Name :  getSubjectAttendances
         * Objective : Find avarage attendance per subject.	
         * Input : List of student data.
         * return : List of avarage attendance per subject.
         * Date : 20\04\22
         */
        public List<SubjectAttendance> getSubjectAttendances(List<StudentData> list)
        {
            Dictionary<string, SubjectAttendance> dic = new Dictionary<string, SubjectAttendance>();
            List<SubjectAttendance> result = new List<SubjectAttendance>();


            foreach (StudentData studentData in list)
            {
                if (dic.ContainsKey(studentData.Subject))
                {
                    SubjectAttendance subjectAttendance = dic[studentData.Subject];
                    subjectAttendance.TotalAttendance += studentData.Attendance;
                    subjectAttendance.Count++;

                }
                else
                {
                    SubjectAttendance subjectAttendance = new SubjectAttendance();
                    subjectAttendance.Subject = studentData.Subject;
                    subjectAttendance.TotalAttendance = studentData.Attendance;
                    subjectAttendance.Count++;
                    dic.Add(studentData.Subject, subjectAttendance);
                }
            }
            foreach (var element in dic)
            {
                element.Value.AverageAttendance = element.Value.TotalAttendance / element.Value.Count;
                result.Add(element.Value);
            }
            return result;
        }
        /**
         * Method Name :  getMaxAttendanceStudents
         * Objective : Find name of students who has maximum attendance across all subject.					
         * Input : List of student data.
         * return : Give maximum student attedance name.
         * Date : 20\04\22
         */

       //Genrate a method which gives list of students including totalAttedance.
        public List<MaxAttendanceStudent> getTotalAttendance(List<StudentData> studentDetailList)
        {
            Dictionary<string, MaxAttendanceStudent> result = new Dictionary<string, MaxAttendanceStudent>();
            foreach (var studentDetail in studentDetailList)
            {
                if (result.ContainsKey(studentDetail.Name))
                {
                    result[studentDetail.Name].TotalAttendance += studentDetail.Attendance;
                }
                else
                {
                    MaxAttendanceStudent newObject = new MaxAttendanceStudent();
                    newObject.Name = studentDetail.Name;
                    newObject.TotalAttendance = studentDetail.Attendance;
                    result.Add(studentDetail.Name, newObject);
                }
            }
            return result.Values.ToList();
        }
        // Find name of students who has maximum attendance across all subject using object.
        public MaxAttendanceStudent getMaxAttendanceStudents(List<MaxAttendanceStudent> totalAttandanceList)
        {
            MaxAttendanceStudent newObject = new MaxAttendanceStudent();
            newObject.TotalAttendance = totalAttandanceList[0].TotalAttendance;
            newObject.Name = totalAttandanceList[0].Name;
            foreach (var studentDetail in totalAttandanceList)
            {
                if (newObject.TotalAttendance < studentDetail.TotalAttendance)
                {
                    newObject.TotalAttendance = studentDetail.TotalAttendance;
                    newObject.Name = studentDetail.Name;
                }
            }
            return newObject;
        }
        /* 
          public MaxAttendanceStudent getMinAttendanceStudents(List<StudentData>List)
          {
           Dictionary<string, MaxAttendanceStudent> dict = new Dictionary<string, MaxAttendanceStudent>();

         foreach (StudentData studentData in list)
         {
             if(dict.ContainsKey(studentData.Name))
             {
                // MaxAttendanceStudent maxAttendanceStudent = dict[studentData.Name];
                 dict[studentData.Name].TotalAttendance +=studentData.Attendance;
             }
             else
             {
                 // MaxAttendanceStudent maxAttendanceStudent = new MaxAttendanceStudent();
                 dict.Add(studentData.Name,new MaxAttendanceStudent());
                 dict[studentData.Name].Name = studentData.Name;
                 dict[studentData.Name].TotalAttendance = studentData.Attendance;


             }
         }
       MaxAttendanceStudent maxAttendanceStudent = new MaxAttendanceStudent();
         maxAttendanceStudent.TotalAttendance = int.MinValue;
         //   List<MaxAttendanceStudent> result = new List<MaxAttendanceStudent>();
         foreach (MaxAttendanceStudent element in dict.Values)
         {
             if (element.TotalAttendance > maxAttendanceStudent.TotalAttendance)
             {
                 maxAttendanceStudent.TotalAttendance = element.TotalAttendance;
                 maxAttendanceStudent.Name = element.Name;
             }
         }

         return maxAttendanceStudent;*/




        /**
        * Method Name : getMinAttendanceStudents
        * Objective :Find name of students who has minimum attendance across all subject.								
        * Input : List of student data.
        * return : Give student name who has minimum attendance.
        * Date : 20\04\22
*/

        //Find Mimimum attendance across all subject using map.
        /*   public MaxAttendanceStudent getMinAttendanceStudents(List<StudentData>List)
          {

            Dictionary<string, MinAttendanceStudent> dict = new Dictionary<string, MinAttendanceStudent>();

            foreach (StudentData studentData in list)
            {
                if (dict.ContainsKey(studentData.Name))
                {
                    // MaxAttendanceStudent maxAttendanceStudent = dict[studentData.Name];
                    dict[studentData.Name].TotalAttendance += studentData.Attendance;
                }
                else
                {
                    // MaxAttendanceStudent maxAttendanceStudent = new MaxAttendanceStudent();
                    dict.Add(studentData.Name, new MinAttendanceStudent());
                    dict[studentData.Name].Name = studentData.Name;
                    dict[studentData.Name].TotalAttendance = studentData.Attendance;


                }
            }
            MinAttendanceStudent minAttendanceStudent = new MinAttendanceStudent();
            minAttendanceStudent.TotalAttendance = int.MaxValue;
            foreach (MinAttendanceStudent element in dict.Values)
            {
                if (element.TotalAttendance < minAttendanceStudent.TotalAttendance)
                {
                    minAttendanceStudent.TotalAttendance = element.TotalAttendance;
                    minAttendanceStudent.Name = element.Name;
                }
            }

            return minAttendanceStudent; */
        //Find Mimimum attendance across all subject using Object.
        public MaxAttendanceStudent getMinAttendanceStudents(List<MaxAttendanceStudent> totalAttandanceList)
            {
                MaxAttendanceStudent newObject = new MaxAttendanceStudent();
            newObject.TotalAttendance = totalAttandanceList[0].TotalAttendance;
            newObject.Name = totalAttandanceList[0].Name;
            foreach (var studentDetail in totalAttandanceList)
            {
                if (newObject.TotalAttendance > studentDetail.TotalAttendance)
                {
                    newObject.TotalAttendance = studentDetail.TotalAttendance;
                    newObject.Name = studentDetail.Name;
                }
            }
            return newObject;



        }
        /**
        * Method Name : getStudentHighestAttendance
        * Objective : Find name of students who has highest attendence in each subject.			.								
        * Input : List of student data.
        * return : Give List of name of students who has highest attendence in each subject.
        * Date : 20\04\22
        */
        public List<StudentHighestAttendance> getStudentHighestAttendance(List<StudentData> list)
        {
            Dictionary<string, StudentHighestAttendance> dictionary = new Dictionary<string, StudentHighestAttendance>();
            List<StudentHighestAttendance> result = new List<StudentHighestAttendance>();
            foreach (StudentData studentData in list)
            {
                if (dictionary.ContainsKey(studentData.Subject))
                {
                    if (dictionary[studentData.Subject].HighestAttendance < studentData.Attendance)
                    {
                        dictionary[studentData.Subject].Name = studentData.Name;
                        dictionary[studentData.Subject].Subject = studentData.Subject;
                        dictionary[studentData.Subject].HighestAttendance = studentData.Attendance;
                    }
                }
                else
                {
                    dictionary.Add(studentData.Subject, new StudentHighestAttendance());
                    dictionary[studentData.Subject].Name = studentData.Name;
                    dictionary[studentData.Subject].Subject = studentData.Subject;
                    dictionary[studentData.Subject].HighestAttendance = studentData.Attendance;

                }
            }
            foreach (var element in dictionary.Values)
            {
                result.Add(element);
            }
            return result;
        }
        /**
        * Method Name : getStudentOrderAttendances
        * Objective :List students name in order of their overall attendance across all subjects.			.								
        * Input : List of student data.
        * return : Give List of students name in order of their overall attendance across all subjects.
        * Date : 20\04\22
        */
        public List<StudentOrderAttendance> getStudentOrderAttendances(List<StudentData> list)
        {
            Dictionary<int, StudentOrderAttendance> dic = new Dictionary<int, StudentOrderAttendance>();
            List<StudentOrderAttendance> studentOrderAttendances = new List<StudentOrderAttendance>();
            foreach (StudentData studentData in list)
            {
                if (dic.ContainsKey(studentData.RollNumber))
                {
                    dic[studentData.RollNumber].Name = studentData.Name;
                    dic[studentData.RollNumber].Subject = studentData.Subject;
                    dic[studentData.RollNumber].OverallAttendance += studentData.Attendance;
                }
                else
                {
                    dic.Add(studentData.RollNumber, new StudentOrderAttendance());
                    dic[studentData.RollNumber].Name = studentData.Name;
                    dic[studentData.RollNumber].Subject = studentData.Subject;
                    dic[studentData.RollNumber].OverallAttendance = studentData.Attendance;
                }
            }
            foreach (var element in dic.Values)
            {
                studentOrderAttendances.Add(element);
            }
            studentOrderAttendances.Sort((Value1, Value2) => Value2.OverallAttendance.CompareTo(Value1.OverallAttendance));
            return studentOrderAttendances;
        }
    }
}
    
    


