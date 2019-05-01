using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//esto se agrego
using System.Data.SqlClient;
using System.Data.Common;
using System.Data.Sql;

namespace CapaDatos
{
    public class bdConex
    {
        String cadenaConex = "Data Source=.;Initial Catalog=DBFACTURAS;Persist Security Info=True;User ID=juan_perez2;Password=123";

        public bool conex()
        {
            bool correcto = false;
            try 
            {
                correcto = true;
            }
            catch (Exception ex) 
            {
                correcto = false;
            }
            return correcto;
        }
    }
}
