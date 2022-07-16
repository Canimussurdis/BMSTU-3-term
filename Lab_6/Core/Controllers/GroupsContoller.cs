using System;
using System.Collections.Generic;
using System.Text;
using DatabaseContext;
using Microsoft.EntityFrameworkCore;
using DatabaseModels;
using System.Linq;

namespace Core
{
    class GroupsContoller
    {
        private readonly UniversityContext universityContext;

        public GroupsContoller(UniversityContext context)
        {
            universityContext = context;
        }

        public void AddGroup(string name)
        {
            if (name == "")
            {
                throw new Exception("Name cannot be empty");
            }

            int id = Utils.GenerateId(universityContext.Groups);
            universityContext.Add(new Group(id, name));
            universityContext.SaveChanges();
        }

        public List<Group> GetAllGroups()
        {
            return universityContext.Groups.ToList();
        }

        public void UpdateGroup(int id, string name)
        {
            var group = universityContext.Groups.FirstOrDefault(group => group.Id == id);

            if (group == null)
            {
                throw new Exception("Group not found");
            }

            if (name == "")
            {
                throw new Exception("Name cannot be empty");
            }

            group.Name = name;

            universityContext.SaveChanges();
        }

        public void DeleteGroup(int id)
        {
            var group = universityContext.Groups.FirstOrDefault(group => group.Id == id);

            if (group == null)
            {
                throw new Exception("Group not found");
            }

            universityContext.Groups.Remove(group);
            universityContext.SaveChanges();
        }
    }
}
