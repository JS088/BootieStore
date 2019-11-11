using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BootieStore
{
    public partial class Contact : System.Web.UI.Page
    {
        Connection.Connectivity instance = new Connection.Connectivity();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void msg_Click(object sender, EventArgs e)
        {
            String Cmd = "insert into Contact(Name,Email,Phone,Msg) values('" + txtName.Text.ToString() + "','" + txtEmail.Text.ToString() + "','" + txtContact.Text.ToString() + "','" + txtMsg.Text.ToString() + "')";
            instance.record(Cmd);
            data.InnerHtml = "We will act upon your query";

            txtName.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            txtMsg.Text = "";

        }
    }
}