using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFMFirst
{
    class Program
    {
        static StudentDBEntitiesContainer db = new StudentDBEntitiesContainer();
        static void Main(string[] args)
        {
            Student s1 = new Student { FirstName = "John", LastName = "Martin" };
            Student s2 = new Student { FirstName = "Tom", LastName = "Duglace" };
            Student s3 = new Student { FirstName = "Wade", LastName = "jhonson" };
            Student s4 = new Student { FirstName = "Peter", LastName = "Marker" };
            Student s5 = new Student { FirstName = "Mike", LastName = "Manden" };

            List<Student> students = new List<Student> { s1, s2, s3, s4, s5 };
            //DeleteStudents();
            //db.Students.AddRange(students);
            //db.SaveChanges();

            //var studentsInDB = db.Students.ToList();
            //foreach (var item in studentsInDB)
            //{
            //    Console.WriteLine($"{item.Id} : {item.FirstName} {item.LastName}");

               Console.ReadKey();
            //}
        }
        #region Delete Employee
        private static void DeleteStudents()
        {
            var stuToDelete = db.Students.Where(s => s.Id == 15).FirstOrDefault();
            if (stuToDelete != null)
            {
                db.Students.Remove(stuToDelete);
                db.SaveChanges();
            }
        }
        #endregion
    }
}
