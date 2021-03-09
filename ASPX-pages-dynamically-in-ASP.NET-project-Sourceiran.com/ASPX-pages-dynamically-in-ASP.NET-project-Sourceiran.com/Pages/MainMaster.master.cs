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

public partial class MainMaster : System.Web.UI.MasterPage
{
    private string _pageID;

   
    public string PageID
    {
        get
        {
            return _pageID;
        }
        set
        {
            _pageID = value;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        this.lblPageHead.Text = this.Page.Title;        
    }
}
