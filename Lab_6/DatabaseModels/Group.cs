using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseModels
{
    public class Group: IModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime CreationDate { get; private set; }

        public ICollection<Student> Students { get; set; }

        public Curator Curator { get; set; }

        public Group(int id, string name)
        {
            Id = id;
            Name = name;
            CreationDate = DateTime.Now;
        }
    }
}
