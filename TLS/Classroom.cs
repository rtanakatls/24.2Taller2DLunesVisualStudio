using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2DVisualStudioSemana1.TLS
{
    internal class Classroom
    {
        private string name;
        private List<Student> students;

        public string Name { get { return name; } }
        public List<Student> Students { get { return students; } }

        public Classroom(string name)
        {
            this.name = name;
            students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void RemoveStudent(int index)
        {
            students.RemoveAt(index);
        }

        public int CountPassedStudents()
        {
            int count = 0;
            foreach (Student student in students)
            {
                if (student.GetFinalGrade() >= 12.5f)
                {
                    count++;
                }
            }

            return count;
        }

        public int CountFailedStudents()
        {
            return students.Count - CountPassedStudents();
        }


        public List<Student> GetPassedStudents()
        {
            List<Student> passedStudents=new List<Student>();
            foreach (Student student in students)
            {
                if (student.GetFinalGrade() >= 12.5f)
                {
                    passedStudents.Add(student);
                }
            }

            return passedStudents;
        }

        public List<Student> GetFailedStudents()
        {

            List<Student> failedStudents = new List<Student>();
            foreach (Student student in students)
            {
                if (student.GetFinalGrade() < 12.5f)
                {
                    failedStudents.Add(student);
                }
            }

            return failedStudents;
        }

        public float GetClassroomAverage()
        {
            float result = 0;
            foreach (Student student in students)
            {
                result += student.GetFinalGrade();
            }
            return result / students.Count;
        }
    }
}
