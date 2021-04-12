using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Bbiblioo
{
    public class Connection
    {
        public void connection()
        {
            SqlConnection connexion = new SqlConnection(@"Data Source = NomBaseDeDonne; Server=LAPTOP-B05KADL6\BASEAFPA; Database=NomBaseDeDonne; User Id=sa; Password=Francktolosano06500");
            connexion.Open();
        }
    }
}
