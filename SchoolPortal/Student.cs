using System;

namespace SchoolPortal
{
    public class Student
    {
        public int StudentScore { get; set; }
        public int RegNumber { get; set; }
        public string StudentName { get; set; }

        public Student(int studentScore, int regNumber, string studentName)
        {
            StudentScore = studentScore;
            RegNumber = regNumber;
            StudentName = studentName;
        }

        public void GetStudentDetails()
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your registration number");
            int regNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your Score");
            int studentScore = Convert.ToInt32(Console.ReadLine());



            Console.Write("Enter SCI to get marks for Computer Network, Data Structure and C-Sharp\n Enter COM to get marks for Electronic Circuit, Circuit Analysis and Analog Communication. ");

            string request = Console.ReadLine();

        }
    }

    public class ScienceStudent : Student
    {
        public int ComputerNetwork { get; set; }
        public int DataStructure { get; set; }
        public int CSharp { get; set; }

        public ScienceStudent(int studentScore, int regNumber, string studentName, int computernetwork, int datastructure, int csharp) : base(int studentScore, int regNumber, string studentName)
        {
            ComputerNetwork = computernetwork;
            DataStructure = datastructure;
            CSharp = csharp;
        }
    }

    public class CormerceStudent : Student
    {
        public int ElectronicCircuits { set; get; }
        public int CircuitAnalysis { set; get; }
        public int AnalogCommunication { set; get; }

        public CormerceStudent(int studentScore, int regNumber, string studentName, int computernetwork, int datastructure, int csharp) : base(int studentScore, int regNumber, string studentName)



    }
}