using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Para trabajar con Linq, agregamos el siguiete namespace
using System.Data.Linq;

namespace DataAccess
{
    //Heredamos DataContext que es el punto principal de entrada para trabajo de LINQ con SQL.
    internal class Connection : DataContext
    {
        //Elemento de tipo Table que posee la clase User
        public Table<Users> tblUser; 

        //El constructor de la clase, llevará como base la cadena de conexión a la base de datos.
        public Connection() : base("Data Source=localhost; Initial Catalog=dbLoginLinq; Integrated Security=true;") { }
    }
}
