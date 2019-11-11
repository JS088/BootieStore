using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BootieStore
{
    public partial class Login : System.Web.UI.Page
    {
        Connection.Connectivity instance = new Connection.Connectivity();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Click(object sender, EventArgs e)
        {
            try {

                DataTable tbl = new DataTable();

                String Name = txtEmail.Text.ToString();
                String Password = txtPassword.Text.ToString();
                String cmd = "select * from LoginTable where Email='"+Name+"' and Password='"+Password+"'";
                tbl=instance.SelectQuery(cmd);
                if (tbl.Rows.Count > 0)
                {
                    Response.Redirect("Panel.aspx");
                }
                else {
                    data.InnerHtml = "Invalid User Name or Password";
                }

            }
            catch (Exception es) {
                        
            }

        }
    }
}