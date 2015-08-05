using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using System.Data;

public partial class contactInfo : System.Web.UI.UserControl
{

    string userName = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private void GetUserData()
    { 
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string vUserId = "";
        try
        {
            //Get User Id from Session


        }
        catch (Exception ex)
        {
            //   throw;
        }
    }
}