using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Para trabajar con Linq, agregamos los siguientes namespace
using System.Data.Linq.Mapping;
using System.Data.Linq.SqlClient;

namespace DataAccess
{
    [Table(Name = "tblUser")] //Tabla a la que se referencia la clase
    public class Users
    {
        #region Properties
        //La columna o propiedad es auto generadora (IsDbGenerated) y además clave primaria (IsPrimaryKey)
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int idU { get; set; }

        [Column]
        public string userName { get; set; }

        [Column]
        public string passwordU { get; set; }

        [Column]
        public string name { get; set; }

        [Column]
        public bool stateU { get; set; }

        [Column]
        public string roleU { get; set; }

        [Column]
        public DateTime rDate { get; set; }
        #endregion

        #region Methods
        public static Users login(string user, string password)
        {
            //Se utiliza using para que automáticamente limpie los recursos utilizados
            using (Connection db = new Connection())
            {
                /* El SingleOrDefault devuelve el único elemento de una secuencia o un 
                 * valor predeterminado si la secuencia está vacía */
                Users cUser = (from u in db.tblUser
                              where u.userName == user && u.passwordU == password
                              select u).SingleOrDefault();                
                return cUser;
            }
        }
        #endregion
    }
}
