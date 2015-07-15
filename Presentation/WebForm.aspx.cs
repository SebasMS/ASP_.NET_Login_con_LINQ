using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//Importamos el otro proyecto de la solución
using DataAccess;

namespace Presentation
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnter_Click(object sender, EventArgs e)
        {
            Users user = Users.login(txtUser.Text, txtPassword.Text);
            lblResult.Text = "Bienvenido " + user.name;
        }
    }
}