using System;
using System.Collections.Generic;
using System.Text;
using DatabaseContext;
using Microsoft.EntityFrameworkCore;
using DatabaseModels;
using System.Linq;

namespace Core
{
    class CuratorsController
    {
        private readonly UniversityContext universityContext;

        public CuratorsController(UniversityContext context)
        {
            universityContext = context;
        }

        public void AddCurator(string name, string email, int groupId)
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

            int id = Utils.GenerateId(universityContext.Curators);

            universityContext.Add(new Curator(id, name, email, groupId));
            universityContext.SaveChanges();
        }

        public List<Curator> GetAllCurators()
        {
            return universityContext.Curators.ToList();
        }

        public void UpdateCurator(int id, string name, string email, int groupId)
        {
            var curator = universityContext.Curators.FirstOrDefault(curator => curator.Id == id);

            if (curator == null)
            {
                throw new Exception("Curator not found");
            }

            if (name == "")
            {
                throw new Exception("Name cannot be empty");
            }

            curator.Name = name;
            curator.Email = email;
            curator.GroupId = groupId;

            universityContext.SaveChanges();
        }

        public void DeleteCurator(int id)
        {
            var curator = universityContext.Curators.FirstOrDefault(curator => curator.Id == id);

            if (curator == null)
            {
                throw new Exception("Group not found");
            }

            universityContext.Curators.Remove(curator);
            universityContext.SaveChanges();
        }
    }
}
