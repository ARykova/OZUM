using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IUser
    {
        int Id { get; set; }

        string Login { get; set; }
        string Password { get; set; }

        string Name { get; set; }
        string Information { get; set; }
        string Telephone { get; set; }
        string Mail { get; set; }

       
        
    }
}
