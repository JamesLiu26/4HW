using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _4HW {
    public partial class DropdownListShow : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

            string[] place = { "基隆", "台北", "新北", "苗栗", "台中", "南投" };

            if (dbl_Area.Items.Count==0)
            {
                dbl_Area.Items.Add("北區");
                dbl_Area.Items.Add("中區");
                for (int p = 0; p < place.Length; p++)
                {
                    dbl_Place.Items.Add(place[p]);
                    if (p < 3)
                        dbl_Place.Items[p].Enabled = true;
                    else
                        dbl_Place.Items[p].Enabled = false;
                }
            }

            if (dbl_Area.SelectedIndex == 0)
            {
                for (int p = 0; p < place.Length; p++)
                {
                    if (p < 3)
                        dbl_Place.Items[p].Enabled = true;
                    else
                        dbl_Place.Items[p].Enabled = false;
                }

            }
            else
            {
                for (int p = 0; p < place.Length; p++)
                {
                    if (p > 2)
                        dbl_Place.Items[p].Enabled = true;
                    else
                        dbl_Place.Items[p].Enabled = false;
                }
            }
        }
    }
}