using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataLayer.Repositories
{
    public interface IUserRepository
    {
        int getUserIdByName(string name);
        string getUserNameById(int id);
    }
}
