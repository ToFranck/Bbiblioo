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
            SqlConnection connexion = new SqlConnection(@"Data Source = Bbiblio; Server=DESKTOP-AESM6JA\SQLTOLOSANO; Database=Bbiblio; User Id=sa; Password=Francktolosano06500");
            connexion.Open();
        }
    }
}
