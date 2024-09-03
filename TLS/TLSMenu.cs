using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2DVisualStudioSemana1.TLS
{
    internal class TLSMenu
    {
        private List<Classroom> classrooms;

        public TLSMenu()
        {
            classrooms = new List<Classroom>();
        }
        
        public void Execute()
        {
            ShowMenu();
        }

        private void ShowMenu()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introduce la opción: ");
                Console.WriteLine("1. Crear un salón");
                Console.WriteLine("2. Seleccionar un salón");
                Console.WriteLine("0. Salir");
                string option= Console.ReadLine();
                switch(option)
                {
                    case "1":
                        ShowCreateClassroomMenu();
                        break;
                    case "2":
                        ShowSelectClassroomMenu();
                        break;
                    case "0":
                        continueFlag = false;
                        break;
                }
            }
        }

        private void ShowCreateClassroomMenu()
        {
            string name;
            Console.WriteLine("Introduce el nombre del salón");
            name= Console.ReadLine();
            Classroom classroom = new Classroom(name);
            Console.WriteLine($"Se creó el salón {classroom.Name}");
            classrooms.Add(classroom);
        }

        private void ShowSelectClassroomMenu()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introduce el número del salón");
                for (int i = 0; i < classrooms.Count; i++)
                {
                    Console.WriteLine($"{i}. {classrooms[i].Name}");
                }
                Console.WriteLine("Introduce -1 para salir");
                int option = int.Parse(Console.ReadLine());
                if (option < -1 || option >= classrooms.Count)
                {
                    Console.WriteLine("El salón no existe");
                }
                else if (option == -1)
                {
                    continueFlag = false;
                }
                else
                {
                    Console.WriteLine($"Seleccionaste el salón {classrooms[option].Name}");
                    ShowClassroomMenu(classrooms[option]);
                }
            }
        }

        private void ShowClassroomMenu(Classroom classroom)
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introduce la opción");
                Console.WriteLine("1. Mostrar todos los alumnos");
                Console.WriteLine("2. Añadir un alumno");
                Console.WriteLine("3. Eliminar un alumno");
                Console.WriteLine("4. Mostrar la cantidad de aprobados");
                Console.WriteLine("5. Mostrar la cantidad de desaprobados");
                Console.WriteLine("6. Mostrar lista de alumnos aprobados");
                Console.WriteLine("7. Mostrar lista de alumnos desaprobados");
                Console.WriteLine("8. Mostrar promedio del salón");
                Console.WriteLine("0. Regresar");
                string option= Console.ReadLine();
                switch (option)
                {
                    case "1":
                        ShowStudents(classroom.Students);
                        break;
                    case "2":
                        ShowAddStudentMenu(classroom);
                        break;
                    case "3":
                        ShowRemoveStudentMenu(classroom);
                        break;
                    case "4":
                        Console.WriteLine($"Aprobaron {classroom.CountPassedStudents()}");
                        break;
                    case "5":
                        Console.WriteLine($"Desaprobaron {classroom.CountFailedStudents()}");
                        break;
                    case "6":
                        Console.WriteLine("Lista de aprobados");
                        ShowStudents(classroom.GetPassedStudents());
                        break;
                    case "7":
                        Console.WriteLine("Lista de desaprobados");
                        ShowStudents(classroom.GetFailedStudents());
                        break;
                    case "8":
                        Console.WriteLine($"El promedio del salón es {classroom.GetClassroomAverage()}");
                        break;
                    case "0":
                        continueFlag = false;
                        break;
                }
            }
        }

        private void ShowStudents(List<Student> students)
        {
            for(int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{i}. {students[i].Name} - {students[i].GetFinalGrade()}");
            }
        }

        private void ShowAddStudentMenu(Classroom classroom)
        {
            Console.WriteLine("Introduce el nombre del alumno");
            string name= Console.ReadLine();
            Console.WriteLine("Introduce la primera nota");
            float grade1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la segunda nota");
            float grade2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la tercera nota");
            float grade3 = float.Parse(Console.ReadLine());
            Student student=new Student(name, grade1, grade2, grade3);  
            classroom.AddStudent(student);
        }

        private void ShowRemoveStudentMenu(Classroom classroom)
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introduce el número del alumno a eliminar");
                ShowStudents(classroom.Students);
                Console.WriteLine("Introduce -1 si no quieres quitar ningún alumno");
                int option = int.Parse(Console.ReadLine());
                if(option<-1||option>=classroom.Students.Count)
                {
                    Console.WriteLine("El número no existe");
                }
                else if(option==-1)
                {
                    continueFlag = false;
                }
                else
                {
                    classroom.RemoveStudent(option);
                }
            }
        }
    }
}
