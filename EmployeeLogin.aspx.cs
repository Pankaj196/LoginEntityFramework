using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginEntityFramework
{
    public partial class CustomerLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            EmployeeContext empContext = new EmployeeContext();
            var query = from Employee in empContext.employee where Employee.username == txtUName.Text
                        && Employee.passowrd == txtPwd.Text
                        select Employee;
            
            
            var username = "";
            var password = "";
           foreach(var employee in query)
            {
                username = employee.username;
                Response.Write(username);
                password = employee.passowrd;
                Response.Write(password);
            }

           if(query.Count() > 0)
            {
                Response.Redirect("LoginSuccess.aspx");
            }
            else
            {
                Response.Write("Invalid Cred");
            }
        }
    }
}