using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using DatabaseContext;
using Microsoft.EntityFrameworkCore;
using DatabaseModels;
using System.Threading.Tasks;
using System.Data;
using System.Linq;

namespace Core
{
    public class UniversityFacade
    {
        private readonly GroupsContoller groupsContoller;
        private readonly StudentsController studentsController;
        private readonly CuratorsController curatorsController;
        private readonly MetricsController metricsController;

        public UniversityFacade()
        {
            string connectionString = "User ID=postgres;Password=GCTP_2213.00;Server=localhost;Port=5432;Database=university-database;";

            var optionsBuilder = new DbContextOptionsBuilder<UniversityContext>();

            optionsBuilder.UseNpgsql(connectionString);

            UniversityContext universityContext = new UniversityContext(optionsBuilder.Options);

            groupsContoller = new GroupsContoller(universityContext);
            studentsController = new StudentsController(universityContext);
            curatorsController = new CuratorsController(universityContext);
            metricsController = new MetricsController(universityContext);
        }

        #region Students

        public void AddStudent(string name, int age, int groupId)
        {
            studentsController.AddStudent(name, age, groupId);
        }

        public List<Student> GetAllStudents()
        {
            return studentsController.GetAllStudents();
        }

        public void UpdateStudent(int id, string name, int age, int groupId)
        {
            studentsController.UpdateStudent(id, name, age, groupId);
        }

        public void DeleteStudent(int id)
        {
            studentsController.DeleteStudent(id);
        }

        #endregion

        #region Groups
        public void AddGroup(string name)
        {
            groupsContoller.AddGroup(name);
        }

        public List<Group> GetAllGroups()
        {
            return groupsContoller.GetAllGroups();
        }

        public void UpdateGroup(int id, string name)
        {
            groupsContoller.UpdateGroup(id, name);
        }

        public void DeleteGroup(int id)
        {
            groupsContoller.DeleteGroup(id);
        }

        #endregion

        #region Curators

        public void AddCurator(string name, string email, int groupId)
        {
            curatorsController.AddCurator(name, email, groupId);
        }

        public List<Curator> GetAllCurators()
        {
            return curatorsController.GetAllCurators();
        }

        public void UpdateCurator(int id, string name, string email, int groupId)
        {
            curatorsController.UpdateCurator(id, name, email, groupId);
        }

        public void DeleteCurator(int id)
        {
            curatorsController.DeleteCurator(id);
        }

        #endregion

        #region Metrics

        public int CountStudentsInGroup(int groupId)
        {
            return metricsController.CountStudentsInGroup(groupId);
        }

        public string GetCuratourName(int studentId)
        {

            return metricsController.GetCuratourName(studentId);
        }

        public double GetAverageAge(int curatorId)
        {
            return metricsController.GetAverageAge(curatorId);
        }

        #endregion
    }
}
