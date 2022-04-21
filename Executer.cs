using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubjectAtendenceProject
{
    /**
    * class Name : Executer
    * Objective : To Execute all methods.
    * @author : Ritika jaiswal
    * Date : 20\04\22
    **/
    public class Executer
    {
        public static void Main(String[] args)
        {
            List<StudentData> students = new List<StudentData>();
            students.Add(new StudentData(101, "Ravi", "English", 24));
            students.Add(new StudentData(101, "Ravi", "Maths", 20));
            students.Add(new StudentData(101, "Ravi", "Physics", 23));
            students.Add(new StudentData(101, "Ravi", "Chem", 24));
            students.Add(new StudentData(102, "Rakesh", "English", 21));
            students.Add(new StudentData(102, "Rakesh", "Maths", 22));
            students.Add(new StudentData(102, "Rakesh", "Physics", 20));
            students.Add(new StudentData(102, "Rakesh", "Chem", 24));
            students.Add(new StudentData(103, "Akash", "English", 22));
            students.Add(new StudentData(103, "Akash", "Maths", 19));
            students.Add(new StudentData(103, "Akash", "Physics", 20));
            students.Add(new StudentData(103, "Akash", "Chem", 21));
            students.Add(new StudentData(104, "Vikram", "English", 21));
            students.Add(new StudentData(104, "Vikram", "Maths", 22));
            students.Add(new StudentData(104, "Vikram", "Physics", 20));
            students.Add(new StudentData(104, "Vikram", "Chem", 24));

            StudentAttandanceImpl studentAttandanceImpl = new StudentAttandanceImpl();
            Console.WriteLine("First Problem");
            List<SubjectAttendance> finalRresult = studentAttandanceImpl.getSubjectAttendances(students);
            foreach (SubjectAttendance attendance in finalRresult)
            {
                Console.WriteLine(attendance);
            }
            Console.WriteLine();

            //Console.WriteLine("Second Problem");
            //MaxAttendanceStudent finalresult2 = studentAttandanceImpl.getMaxAttendanceStudents(students);
            //Console.WriteLine(finalresult2);
            //Console.WriteLine();

           // Console.WriteLine("Third Problem");
           // MinAttendanceStudent finalResult3 = studentAttandanceImpl.getMinAttendanceStudents(students);
            //Console.WriteLine(finalResult3);
            //Console.WriteLine();

            Console.WriteLine("Fourth Problem");
            List<StudentHighestAttendance> finalResult4 = studentAttandanceImpl.getStudentHighestAttendance(students);
            foreach(StudentHighestAttendance attendance in finalResult4)
            {
                Console.WriteLine(attendance);
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Fifths Problem");
            List<StudentOrderAttendance> finalResult5 = studentAttandanceImpl.getStudentOrderAttendances(students);
            foreach(StudentOrderAttendance studentOrder in finalResult5)
            {
                Console.WriteLine(studentOrder);
            }
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("second mathod");
            List<MaxAttendanceStudent> totalAttendanceList = studentAttandanceImpl.getTotalAttendance(students);
            MaxAttendanceStudent result = studentAttandanceImpl.getMaxAttendanceStudents(totalAttendanceList);
            Console.WriteLine(result);

            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Third Problem");
            MaxAttendanceStudent result1 = studentAttandanceImpl.getMinAttendanceStudents(totalAttendanceList);
            Console.WriteLine(result1);
        }
    }
}
