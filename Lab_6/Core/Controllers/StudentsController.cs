using System;
using System.Collections.Generic;
using System.Text;
using DatabaseContext;
using Microsoft.EntityFrameworkCore;
using DatabaseModels;
using System.Linq;

namespace Core
{
    class StudentsController
    {
        private readonly UniversityContext universityContext;

        public StudentsController(UniversityContext context)
        {
            universityContext = context;
        }

        public void AddStudent(string name, int age, int groupId)
        {
            var group = universityContext.Groups.FirstOrDefault(group => group.Id == groupId);

            if (group == null)
            {
                throw new Exception("Group not found");
            }

            if (name == "")
            {
                throw new Exception("Name cannot be empty");
            }

            if (age < 5)
            {
                throw new Exception("Wrong!");
            }

            int id = Utils.GenerateId(universityContext.Students);
            universityContext.Add(new Student(id, name, age, groupId));
            universityContext.SaveChanges();
        }

        public List<Student> GetAllStudents()
        {
            return universityContext.Students.ToList();
        }

        public void UpdateStudent(int id, string name, int age, int groupId)
        {
            var student = universityContext.Students.FirstOrDefault(student => student.Id == id);

            if (student == null)
            {
                throw new Exception("Student not found");
            }

            if (name == "")
            {
                throw new Exception("Name cannot be empty");
            }

            student.Name = name;
            student.Age = age;
            student.GroupId = groupId;

            universityContext.SaveChanges();
        }

        public void DeleteStudent(int id)
        {
            var student = universityContext.Students.FirstOrDefault(student => student.Id == id);

            if (student == null)
            {
                throw new Exception("Student not found");
            }

            universityContext.Students.Remove(student);
            universityContext.SaveChanges();
        }
    }
}
