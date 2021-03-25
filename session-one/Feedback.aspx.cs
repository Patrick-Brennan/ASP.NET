using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace session_one
{
    public partial class Feedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ListItem item1 = new ListItem("Male", "0");
                RbtnGender.Items.Add(item1);
                RbtnGender.Items.Add(new ListItem("Female", "1"));
                RbtnGender.SelectedValue = "0";
                //RbtnGender.Items.Add("Male");
                //RbtnGender.Items.Add("Female");

                drpDownCourses.Items.Add("Data structure");
                drpDownCourses.Items.Add("C#");
                drpDownCourses.Items.Add(".NET Fundamental");
            }
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string gender = RbtnGender.SelectedValue == "0" ? "Mr" : "Miss";
            lblMessage.Text = string.Format("Thanks {0} {1} for your feedback", gender, txtStudentName.Text);
        }
    }
}