using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseModels
{
    public class Student: IModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public int GroupId { get; set; }

        public Group Group { get; set; }

        public Student(int id, string name, int age, int groupId)
        {
            Id = id;
            Name = name;
            Age = age;
            GroupId = groupId;
        }
    }
}
