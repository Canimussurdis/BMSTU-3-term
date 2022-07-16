using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseModels
{
    public class Curator: IModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public int GroupId { get; set; }

        public Group Group { get; set; }

        public Curator(int id, string name, string email, int groupId)
        {
            Id = id;
            Name = name;
            Email = email;
            GroupId = groupId;
        }
    }
}
