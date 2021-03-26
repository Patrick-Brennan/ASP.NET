using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace validation.Controls
{
    public partial class SelectTableList : System.Web.UI.UserControl
    {

        public string Title {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }
        public string InitialItems
        {
            get
            {
                return lblTitle.Text;
            }
            set
            {
                string[] items = value.Split(',');
                lstSource.Items.Clear();
                foreach(String item in items)
                {
                    lstSource.Items.Add(new ListItem(item));
                }
            }
        }

        //1- Get a bunch of fruits to populate the source list view
        //2- Add Events to the 4 buttons to move the fruits from source to destination

        //3- Practice the validation controls for submitting the ADDRESS FORM
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnAllRight_Click(object sender, EventArgs e)
        {
            TransferAllItems(lstSource, lstDestination);
        }

        protected void btnSelectedRight_Click(object sender, EventArgs e)
        {
            TransferItems(lstSource, lstDestination);
        }

        protected void btnSelectedLeft_Click(object sender, EventArgs e)
        {
            TransferItems(lstDestination, lstSource);
        }

        protected void btnAllLeft_Click(object sender, EventArgs e)
        {
            TransferAllItems(lstDestination, lstSource);
        }

        private void TransferAllItems(ListBox lstFirst, ListBox lstSecond)
        {
            foreach (ListItem item in lstFirst.Items)
            {
                lstSecond.Items.Add(item);
            }
            lstFirst.Items.Clear();
        }

        private void TransferItems(ListBox lstFirst, ListBox lstSecond)
        {
            List<ListItem> ar1 = new List<ListItem>();
            for (int i = 0; i < lstFirst.Items.Count; i++)
            {
                if (lstFirst.Items[i].Selected)
                {
                    if (!ar1.Contains(lstFirst.Items[i]))
                        ar1.Add(lstFirst.Items[i]);
                }
            }
            for (int i = 0; i < ar1.Count; i++)
            {
                if (!lstSecond.Items.Contains(ar1[i]))
                    lstSecond.Items.Add(ar1[i]);
                lstFirst.Items.Remove(ar1[i]);
            }
            lstSecond.SelectedIndex = -1;
        }
    }
}