using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubjectAtendenceProject
{
    /**
     * class Name : StudentData
     * Objective : To set & get all fields which are used in Implementations 
     * @author : Ritika jaiswal
     * Date : 20\04\22
     **/
    public class StudentData
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public int Attendance { get; set; }

        public StudentData(int rollNumber, string name, string subject, int attendance)
        {
            RollNumber = rollNumber;
            Name = name;
            Subject = subject;
            Attendance = attendance;
        }        
    }

    public class SubjectAttendance
    {
        public string Subject { get; set; }
       
        public int TotalAttendance { get; set; }
        public int Count { get; set; }
        public double AverageAttendance { get; set; }
        public override string ToString()
        {
            return Subject + " " + AverageAttendance;
        }
    }

    public class MaxAttendanceStudent
    {
        public string Name { get; set; }
        public int TotalAttendance { get; set; }
       // public  int MaxAttendance { get; set; }

        public override string ToString()
        {
            return Name + "," + TotalAttendance;
        }
    }

    public class MinAttendanceStudent
    {
        public string Name { get; set; }
        public int TotalAttendance { get; set; }
   
        public override string ToString()
        {
            return Name + "," + TotalAttendance;
        }
    }

    public class StudentHighestAttendance
    {
        public string Name { get; set; }
        public string Subject { get; set;}
        public int HighestAttendance { get; set; }
       // public int Attendance { get; set; } 

        public override string ToString()
        {
            return Name + "," + Subject + "," + HighestAttendance;
        }
    }
    public class StudentOrderAttendance
    {
        public string Name { get; set; }
        public string Subject { get; set; }
        public int OverallAttendance { get; set; }
        public override string ToString()
        {
            return Name + ","  + OverallAttendance;
        }

    }
}
