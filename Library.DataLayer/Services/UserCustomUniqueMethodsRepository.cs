using Library.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataLayer.Services
{
    public class UserCustomUniqueMethodsRepository : IUserRepository
    {
        private Library_DB db;
        public UserCustomUniqueMethodsRepository(Library_DB context)
        {
            db = context;
        }
        public int getUserIdByName(string name)
        {
            return db.tblUsers.First(u => u.Name == name).ID;
        }

        public string getUserNameById(int id)
        {
            return db.tblUsers.Find(id).Name;
        }
    }
}
