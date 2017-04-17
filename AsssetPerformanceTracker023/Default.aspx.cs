using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AsssetPerformanceTracker023
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                double[] rigged = new double[0];
                ViewState.Add("Rigged", rigged);

                double[] acts = new double[0];
                ViewState.Add("Acts", acts);

                string[] name = new string[0];
                ViewState.Add("Name", name);
            }
        }    

        
        protected void addButton_Click(object sender, EventArgs e)
        {
            double[] rigged = (double[])ViewState["Rigged"];
            double[] acts = (double[])ViewState["Acts"];
            string[] name = (string[])ViewState["Name"];

            Array.Resize(ref rigged, rigged.Length + 1);
            Array.Resize(ref acts, acts.Length + 1);
            Array.Resize(ref name, name.Length + 1);


            int newestRiggedItem = rigged.GetUpperBound(0);
            rigged[newestRiggedItem] = double.Parse(riggedTextBox.Text);
            ViewState["Rigged"] = rigged;

            int newestActsItem = acts.GetUpperBound(0);
            acts[newestActsItem] = double.Parse(actsTextBox.Text);
            ViewState["Acts"] = acts;

            int newestNameItem = name.GetUpperBound(0);
            name[newestNameItem] = nameTextBox.Text;
            ViewState["Name"] = name;




            string[] values = new string[3];
            values[0] = nameTextBox.Text;
            values[1] = riggedTextBox.Text;
            values[2] = actsTextBox.Text;

            resultLabel.Text = String.Format("Total Elections Rigged: {0:N2}<br />Average Acts of Subterfuge: {1:N2}<br />Last Asset you Added: {2}",

                rigged.Sum(),
                acts.Average(),
                name[newestNameItem]);
                            
                riggedTextBox.Text = " ";
                actsTextBox.Text = " ";
                nameTextBox.Text = " ";

            
        }
    }
}