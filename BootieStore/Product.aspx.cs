using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BootieStore
{
    public partial class Product : System.Web.UI.Page
    {
        Connection.Connectivity instance = new Connection.Connectivity();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string file = FileUpload1.FileName;
                FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Shoes/" + file));

                string Photo = "Shoes/" + file.ToString();


                String cmd = "insert into ProductTable(Product,Category,Price,photo) values('" + txtName.Text + "','" + txtCategory.Text + "','" + TxtPrice.Text + "','" + Photo + "')";
                instance.record(cmd);
                data.InnerHtml = "Product is saved";
                txtCategory.Text = "";
                txtName.Text = "";
                TxtPrice.Text = "";

            }

        }
    }
}