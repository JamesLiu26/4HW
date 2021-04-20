using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _4HW {
    public partial class DropdownListShow : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

            if (dbl_Area.Items.Count==0)
            {
                dbl_Area.Items.Add("北區");
                dbl_Area.Items.Add("中區");
            }

            if (dbl_Area.SelectedIndex == 0)
            {
                dbl_Place.Items.Clear();
                dbl_Place.Items.Add("基隆");
                dbl_Place.Items.Add("台北");
                dbl_Place.Items.Add("新北");
            }
            else
            {
                dbl_Place.Items.Clear();
                dbl_Place.Items.Add("苗栗");
                dbl_Place.Items.Add("台中");
                dbl_Place.Items.Add("南投");
            }
        }
    }
}