using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using DatabaseModels;
using System.Linq;

namespace Core
{
    public class Utils
    {
        public static int GenerateId(DbSet<IModel> dbSet)
        {
            return dbSet.Count() == 0 ? 1 : dbSet.Max(item => item.Id) + 1;
        }

        public static int GenerateId(DbSet<Group> dbSet)
        {
            return dbSet.Count() == 0 ? 1 : dbSet.Max(item => item.Id) + 1;
        }

        public static int GenerateId(DbSet<Curator> dbSet)
        {
            return dbSet.Count() == 0 ? 1 : dbSet.Max(item => item.Id) + 1;
        }

        public static int GenerateId(DbSet<Student> dbSet)
        {
            return dbSet.Count() == 0 ? 1 : dbSet.Max(item => item.Id) + 1;
        }
    }
}
