using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web;

namespace WebApplication6
{
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            
        }

        protected void ASPxMenu1_DataBound(object sender, EventArgs e) {
            string url = "";
            for (int i = 0; i < ASPxMenu1.Items.Count; i++) {

                url = ASPxMenu1.Items[i].NavigateUrl;
                ASPxLabel lab = ASPxMenu1.Items[i].FindControl("ASPxLabel1") as ASPxLabel;
                if (lab != null) {
                   lab.ClientSideEvents.Click = "function(s,e){window.location = '" + url + "';}";
                    
                   switch (lab.Text) {
                       case "Yahoo!": {
                               lab.BackColor = System.Drawing.Color.LightPink;
                               break;
                        }
                       case "MSN": {
                               lab.BackColor = System.Drawing.Color.LightSkyBlue;
                               break;
                        }
                       case "Google": {
                               lab.BackColor = System.Drawing.Color.LightSeaGreen;
                               break;
                        }
                  }
              }
          }
      }


  }
}
