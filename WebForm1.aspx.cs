using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace KabezaWebApplication_New
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e);
         }

        protected void Button1_Click(object sender, EventArgs e)
    
        {
        if (Page.IsPostback == true)
        {
             Label1.Text = ("Awesome!Data was Inserted");
        }
         
        {
            SqlConnection Kabezaconn = new SqlConnection("Server=tcp:kabezaserver.database.windows.net,1433;Initial Catalog=kabezaDB;Persist Security Info=False;User ID=kabeza;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            {
                SqlCommand insert = new SqlCommand("EXEC dbo.InsertFullname @Fullname", Kabezaconn);
            insert.Parameters.AddWithValue("@Fullname", TextBox, Text);
                
                Kabezaconn.Open();
                insert.ExecuteNonQuery();
                Kabezaconn.Close();

                if (IsPostBack)
                    {
                    
                    TextBox1.Text = "";
                }
            } 
        }
    }
}
