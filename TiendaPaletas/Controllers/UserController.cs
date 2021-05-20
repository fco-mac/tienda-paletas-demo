using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TiendaPaletas.Controllers
{
    class UserController
    {
        Models.User userM = new Models.User();
        public DataTable getUser(int numeroEmpleado, string nombreEmpleado)
        {
            DataTable dt = new DataTable();
            dt = userM.getUserById(numeroEmpleado,nombreEmpleado);
            return dt;
        }
    }
}
