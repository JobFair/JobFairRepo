using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using Entities.HR;
using System.Data;
using System.Net.Mail;

namespace JobFair.Forms.HR
{
    public partial class ClientRequirements : System.Web.UI.Page
    {
        private DataSet dsClientDetails = new DataSet();
        private ClientRequirementsHRBAL clientRequirementsHRBAL = new ClientRequirementsHRBAL();
        int HrId,ClientId;
        bool isView, isEdit;

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["HrId"] != null)
            //{
            //    if (Session["HrId"].ToString() != "")
            //    {
            //        HrId = Convert.ToString(Session["HrId"]);
                if (!IsPostBack)
                {
                    try
                    {
                        ClientId = Convert.ToInt32(Request.QueryString["ClientId"]);
                        HrId = Convert.ToInt32(Request.QueryString["HrId"]);
                        BindFunctionalArea();
                        BindIndustry();
                        BindCountry();
                        BindClient(HrId, ClientId);
                        BindRecruiter(HrId);

                        isView = Convert.ToBoolean(Request.QueryString["isView"]);
                        if (isView)
                        {
                            try
                            {
                                ClientId = Convert.ToInt32(Request.QueryString["ClientId"]);
                                HrId = Convert.ToInt32(Request.QueryString["HrId"]);
                                BindViewClientRequirements();
                            }
                            catch (Exception)
                            {
                                //throw;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        //throw;
                    }
                }
               
                isEdit = Convert.ToBoolean(Request.QueryString["isEdit"]);
                if (isEdit)
                {
                    try
                    {
                        ClientId = Convert.ToInt32(Request.QueryString["ClientId"]);
                        HrId = Convert.ToInt32(Request.QueryString["HrId"]);
                        BindCountry();
                        //BindEditClient();
                        //btnSubmit.Visible = false;
                        //btnUpdate.Visible = true;
                    }
                    catch (Exception)
                    {
                        //throw;
                    }
                }
            //  }
            //}
        }


        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                ClientRequirementsHRBAL clientRequirementsHRBAL = new ClientRequirementsHRBAL();
                ClientRequirementsHREntity clientRequirementsHREntity = new ClientRequirementsHREntity();
                // Assign values to the entities
                clientRequirementsHREntity.HrId = 1;
                clientRequirementsHREntity.ClientId = Convert.ToInt32(txtClientId.Text.Trim()); ;
                clientRequirementsHREntity.ClientName = txtClientName.Text.Trim();
                clientRequirementsHREntity.ClientProfile = txtClientProfile.Text.Trim();
                clientRequirementsHREntity.Position = txtPosition.Text.Trim();
                clientRequirementsHREntity.Industry = Convert.ToInt32(ddlIndustry.SelectedValue);
                clientRequirementsHREntity.FunctionalArea = Convert.ToInt32(ddlFunctionalArea.SelectedValue);
                clientRequirementsHREntity.Address = txtAddress.Text.Trim();
                clientRequirementsHREntity.CountryId = Convert.ToInt32(ddlCountry.SelectedValue);
                clientRequirementsHREntity.StateId = Convert.ToInt32(ddlState.SelectedValue);
                clientRequirementsHREntity.CityId = Convert.ToInt32(ddlCity.SelectedValue);
                clientRequirementsHREntity.AreaId = Convert.ToInt32(ddlArea.SelectedValue);
                clientRequirementsHREntity.Pincode = Convert.ToInt32(txtPincode.Text.Trim());
                clientRequirementsHREntity.Skillsets = txtSkillsets.Text.Trim();
                clientRequirementsHREntity.Contents = txtContents.Text.Trim();
                clientRequirementsHREntity.DateOfRequirementSent = Convert.ToDateTime(txtDateofRequirementSent.Text);
                clientRequirementsHREntity.DueDate = Convert.ToDateTime(txtDueDate.Text);
                clientRequirementsHREntity.Status = rbtlistStatus.SelectedItem.Text.Trim();
                clientRequirementsHREntity.RecruiterID = Convert.ToInt32(ddlRecruiter.SelectedValue);

                // Saving data to the database
                int result = clientRequirementsHRBAL.SaveClientRequirementsBAL(clientRequirementsHREntity);
                if (result > 0)
                {
                try
                {
                    string strBody = "", ClientName, ClientProfile, Position, IndustryName, FunctionalAreaName, Address, 
			        CountryName, StateName, CityName, AreaName, Skillsets, Contents, Status, RecruiterName;
                    int ClientId,Pincode;
                    DateTime DateOfRequirementSent, DueDate;
                    ClientId = Convert.ToInt32(txtClientId.Text.Trim());
                    ClientName =  txtClientName.Text.Trim();
                    ClientProfile = txtClientProfile.Text.Trim();
                    Position = txtPosition.Text.Trim();
                    IndustryName = ddlIndustry.SelectedItem.Text.Trim();
                    FunctionalAreaName = ddlFunctionalArea.SelectedItem.Text.Trim();
                    Address = txtAddress.Text.Trim();
                    CountryName = ddlCountry.SelectedItem.Text.Trim();
                    StateName = ddlState.SelectedItem.Text.Trim();
                    CityName = ddlCity.SelectedItem.Text.Trim();
                    AreaName = ddlArea.SelectedItem.Text.Trim();
                    Pincode = Convert.ToInt32(txtPincode.Text.Trim());
                    Skillsets = txtSkillsets.Text.Trim();
                    Contents = txtContents.Text.Trim();
                    DateOfRequirementSent = Convert.ToDateTime(txtDateofRequirementSent.Text);
                    DueDate = Convert.ToDateTime(txtDueDate.Text);
                    Status = rbtlistStatus.SelectedItem.Text;
                    RecruiterName = ddlRecruiter.SelectedItem.Text.Trim();

                    MailMessage msg = new MailMessage();
                    msg.From = new MailAddress("logos.expertadvice@gmail.com");

                    DataSet dsSelectClientRequirementsForwardMail = new DataSet();
                    HrId = 1;
                    ClientId = Convert.ToInt32(txtClientId.Text.Trim()); ;
                    string EmailIdJoin = null, EmailId, toemail;
                    dsSelectClientRequirementsForwardMail = clientRequirementsHRBAL.SelectClientRequirementsForwardMailBAL(HrId, ClientId);
                    
                    foreach (DataTable table in dsSelectClientRequirementsForwardMail.Tables)
                    {
                        foreach (DataRow dr in table.Rows)
                        {
                            EmailId = Convert.ToString(dr["EmailId"]); ;
                            if (EmailIdJoin == null)
                            {
                                EmailIdJoin = string.Concat(EmailId + ",");
                            }
                            else
                                EmailIdJoin = string.Concat(EmailIdJoin + EmailId + ",");
                        }
                    }

                    string[] Multi = EmailIdJoin.Split(','); //spiliting input Email id string with comma(,)
                    foreach (string Multiemailid in Multi)
                    {
                        if (Multiemailid != "")
                        {
                            msg.To.Add(new MailAddress(Multiemailid)); //adding multi reciver's Email Id
                        }
                        else
                            break;
                    }

                    //msg.To.Add("avadhoot.logossolutions@gmail.com");
                    //msg.To.Add("backupinfo.logos@gmail.com");
                    msg.Subject = "Client Requirements";
                    // Check if selected value equal to Other Help
           
                        strBody = "<html><body><table><tr><td>Client Id </td><td>:</td><td>" + ClientId + "</td></tr> " +
                            " <tr><td>Client Name  </td><td>:</td><td>" + ClientName + "</td></tr> " +
                           " <tr><td>Client Profile </td><td>:</td><td>" + ClientProfile + "</td></tr> " +
                           " <tr><td>Position</td><td>:</td><td>" + Position + "</td></tr> " +
                           " <tr><td>Industry Name</td><td>:</td><td>" + IndustryName + "</td></tr> " +
                           " <tr><td>Functional Area Name</td><td>:</td><td>" + FunctionalAreaName + "</td></tr> " +
                            " <tr><td>Address </td><td>:</td><td>" + Address + "</td></tr><br /> " +
                            " <tr><td>Country Name</td><td>:</td><td>" + CountryName + "</td></tr><br /> " +
                             " <tr><td>State Name</td><td>:</td><td>" + StateName + "</td></tr><br /> " +
                              " <tr><td>City Name </td><td>:</td><td>" + CityName + "</td></tr><br /> " +
                           " <tr><td>Area Name</td><td>:</td><td>" + AreaName + "</td></tr><br /> " +
                              " <tr><td>Pincode</td><td>:</td><td>" + Pincode + "</td></tr> " +
                           " <tr><td>Skillsets</td><td>:</td><td>" + Skillsets + "</td></tr> " +
                            " <tr><td>Contents</td><td>:</td><td>" + Contents + "</td></tr><br /> " +
                             " <tr><td>Date Of Requirement Sent</td><td>:</td><td>" + DateOfRequirementSent + "</td></tr><br /> " +
                              " <tr><td>Due Date</td><td>:</td><td>" + DueDate + "</td></tr><br /> " +
                               " <tr><td>Status</td><td>:</td><td>" + Status + "</td></tr><br /> " +
                                " <tr><td>RecruiterName</td><td>:</td><td>" + RecruiterName + "</td></tr><br /> " +
        						" </table> </body></html>";
			
                    msg.Body = strBody;
                    msg.IsBodyHtml = true;
                    //"Name :" + name + "\nEmail ID :" + emailId + "\nMobile Number :" + mobileNo + "\nAlternate Mobile Number :" + alternateMobile + "\nTotal Experience :" + totalExperience + "\nPosition Looking for :" + positionLooking + "\nRelevant Experience in the position applied :" + RelevantExpPositionApplied + "\nRelevant Experience in the Mobile Domain :" + RelevantExpMobileDomain + "\nDo you have experience in mobile domain (Android and iPhone) :" + mobileDomain + "\nCurrent / last Employer :" + currentEmployer + "\nWork Tenure :" + workTenture + "\nCurrent Designation :" + currentDesignation + "\nCurrent location :" + currentLocation + "\nCurrent Salary :" + currentSalary + "\nExpected Salary :" + exceptedSalary + "\nNotice Period :" + noticePeriod + "\nSize of organization are you looking for ?" + companyType + "\nReason for the job change :" + reason + "Can you attend face to face interview in weekdays :" + interview + "\nAvailability for the personal interview in Week Days (Monday to Friday) :" + beforeTime + " " + afterTime + "\nPreferable City for Job :" + preferedCity + "\nPreferable areas in the City :" + preferedArea;
                    //if (resumeUpload.HasFile)
                    //{
                    //    string FileName = Path.GetFileName(resumeUpload.PostedFile.FileName);
                    //    msg.Attachments.Add(new Attachment(resumeUpload.PostedFile.InputStream, FileName));
                    //}
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.Credentials = new System.Net.NetworkCredential("logos.expertadvice@gmail.com", "logos@gmail");
                    smtp.EnableSsl = true;
                    smtp.Send(msg);
                    msg = null;
                  }
                     catch (Exception)
                    {
                        //throw;
                    }
                        Response.Write("<script language='javascript'>alert('Client Requirement Successfully Mailed...');</script>");
                        Response.Write("<script language='javascript'>alert('Saved Client Requirement Successfully')</script>");
                }
                else
                {
                    Response.Write("<script language='javascript'>alert('Client Requirement won't saved')</script>");
                }
            }
            catch (Exception)
            {
                //throw;
            }
        }

        /// <summary>
        /// Method for binding Client Details for Viewing Purpose
        /// </summary>
        private void BindViewClientRequirements()
        {
            try
            {
                DataSet dsViewClientRequirements = new DataSet();
                ClientRequirementsHRBAL clientRequirementsHRBAL = new ClientRequirementsHRBAL();
                dsViewClientRequirements = clientRequirementsHRBAL.ViewClientRequirementDetailsBAL(HrId,ClientId);


                if (dsViewClientRequirements != null)
                {
                    repClientDetails.DataSource = dsViewClientRequirements;
                    repClientDetails.DataBind();
                    //lblViewClientName.Text = Convert.ToString(dsViewClientRequirements.Tables[0].Rows[0]["ClientName"]);
                    //lblViewClientProfile.Text = Convert.ToString(dsViewClientRequirements.Tables[0].Rows[0]["ClientProfile"]);
                    //lblViewPositionName.Text = Convert.ToString(dsViewClientRequirements.Tables[0].Rows[0]["Position"]);
                    //lblIndustry.Text = Convert.ToString(dsViewClientRequirements.Tables[0].Rows[0]["IndustryName"]);
                    //lblFunctionalArea.Text = Convert.ToString(dsViewClientRequirements.Tables[0].Rows[0]["FunctionalArea"]);
                    //lblAddress.Text = Convert.ToString(dsViewClientRequirements.Tables[0].Rows[0]["Address"]);
                    //lblCountry.Text = Convert.ToString(dsViewClientRequirements.Tables[0].Rows[0]["CountryName"]);
                    //lblState.Text = Convert.ToString(dsViewClientRequirements.Tables[0].Rows[0]["StateName"]);
                    //lblCity.Text = Convert.ToString(dsViewClientRequirements.Tables[0].Rows[0]["CityName"]);
                    //lblArea.Text = Convert.ToString(dsViewClientRequirements.Tables[0].Rows[0]["AreaName"]);
                    //lblPincode.Text = Convert.ToString(dsViewClientRequirements.Tables[0].Rows[0]["Pincode"]);
                    //lblSkills.Text = Convert.ToString(dsViewClientRequirements.Tables[0].Rows[0]["Skillsets"]);
                    //lblContent.Text = Convert.ToString(dsViewClientRequirements.Tables[0].Rows[0]["Contents"]);
                    //lblDateOfRequirement.Text = Convert.ToString(dsViewClientRequirements.Tables[0].Rows[0]["DateOfRequirementSent"]);
                    //lblDueDate.Text = Convert.ToString(dsViewClientRequirements.Tables[0].Rows[0]["DueDate"]);
                }
            }
            catch (Exception)
            {
                throw;
            }
            divMain.Visible = false;
            divView.Visible = true;
        }

        protected void rptrClientDetails_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            LinkButton lnkUpdate = (LinkButton)e.Item.FindControl("lnkUpdate");
            LinkButton lnkCancel = (LinkButton)e.Item.FindControl("lnkCancel");
            LinkButton lnkEdit = (LinkButton)e.Item.FindControl("lnkEdit");
            LinkButton lnkDelete = (LinkButton)e.Item.FindControl("lnkDelete");
            DropDownList ddlClientName = (DropDownList)e.Item.FindControl("ddlClientName");
            TextBox txtClientProfile = (TextBox)e.Item.FindControl("txtClientProfile");
            TextBox txtPosition = (TextBox)e.Item.FindControl("txtPosition");
            DropDownList ddlIndustry = (DropDownList)e.Item.FindControl("ddlIndustry");
            DropDownList ddlFunctionalArea = (DropDownList)e.Item.FindControl("ddlFunctionalArea");
            TextBox txtAddress = (TextBox)e.Item.FindControl("txtAddress");
            DropDownList ddlCountry = (DropDownList)e.Item.FindControl("ddlCountry");
            DropDownList ddlState = (DropDownList)e.Item.FindControl("ddlState");
            DropDownList ddlCity = (DropDownList)e.Item.FindControl("ddlCity");
            DropDownList ddlArea = (DropDownList)e.Item.FindControl("ddlArea");
            TextBox txtPincode = (TextBox)e.Item.FindControl("txtPincode");
            TextBox txtSkillsets = (TextBox)e.Item.FindControl("txtSkillsets");
            TextBox txtContents = (TextBox)e.Item.FindControl("txtContents");
            TextBox txtDateofRequirementSent = (TextBox)e.Item.FindControl("txtDateofRequirementSent");
            TextBox txtDueDate = (TextBox)e.Item.FindControl("txtDueDate");
            RadioButtonList rbtlistStatus = (RadioButtonList)e.Item.FindControl("rbtlistStatus");
            DropDownList ddlRecruiter = (DropDownList)e.Item.FindControl("ddlRecruiter");

            Label lblClientName = (Label)e.Item.FindControl("lblClientName");
            Label lblClientProfile = (Label)e.Item.FindControl("lblClientProfile");
            Label lblPosition = (Label)e.Item.FindControl("lblPosition");
            Label lblIndustry = (Label)e.Item.FindControl("lblIndustry");
            Label lblFunctionalArea = (Label)e.Item.FindControl("lblFunctionalArea");
            Label lblAddress = (Label)e.Item.FindControl("lblAddress");
            Label lblCountry = (Label)e.Item.FindControl("lblCountry");
            Label lblState = (Label)e.Item.FindControl("lblState");
            Label lblCity = (Label)e.Item.FindControl("lblCity");
            Label lblArea = (Label)e.Item.FindControl("lblArea");
            Label lblPincode = (Label)e.Item.FindControl("lblPincode");
            Label lblSkillsets = (Label)e.Item.FindControl("lblSkillsets");
            Label lblContents = (Label)e.Item.FindControl("lblContents");
            Label lblDateofRequirementSent = (Label)e.Item.FindControl("lblDateofRequirementSent");
            Label lblDueDate = (Label)e.Item.FindControl("lblDueDate");
            Label lblStatus = (Label)e.Item.FindControl("lblStatus");
            Label lblRecruiter = (Label)e.Item.FindControl("lblRecruiter");
          
            
            // Check commond for edit
            if (e.CommandName == "edit")
            {
                BindRecruiter(HrId);
                lnkCancel.Visible = true;
                lnkUpdate.Visible = true;
                lnkEdit.Visible = false;

                txtClientName.Visible = true;
                txtClientProfile.Visible = true;
                txtPosition.Visible = true;
                ddlIndustry.Visible = true;
                ddlFunctionalArea.Visible = true;
                txtAddress.Visible = true;
                ddlCountry.Visible = true;
                ddlState.Visible = true;
                ddlCity.Visible = true;
                ddlArea.Visible = true;
                txtPincode.Visible = true;
                txtSkillsets.Visible = true;
                txtContents.Visible = true;
                txtDateofRequirementSent.Visible = true;
                txtDueDate.Visible = true;
                rbtlistStatus.Visible = true;
                ddlRecruiter.Visible = true;
                pnlRecruiter.Visible = true;

                lblClientName.Visible = false;
                lblClientProfile.Visible = false;
                lblPosition.Visible = false;
                lblIndustry.Visible = false;
                lblFunctionalArea.Visible = false;
                lblAddress.Visible = false;
                lblCountry.Visible = false;
                lblState.Visible = false;
                lblCity.Visible = false;
                lblArea.Visible = false;
                lblPincode.Visible = false;
                lblSkillsets.Visible = false;
                lblContents.Visible = false;
                lblDateofRequirementSent.Visible = false;
                lblDueDate.Visible = false;
                lblStatus.Visible = false;
                lblRecruiter.Visible = false;
                pnlRecruiter.Visible = false;
            }
            // Check commond for update
            if (e.CommandName == "cancel")
            {
                BindViewClientRequirements();
            }
            // Check  commond for update
            if (e.CommandName == "update")
            {
                try
                {
                    ClientRequirementsHRBAL clientRequirementsHRBAL = new ClientRequirementsHRBAL();
                    ClientRequirementsHREntity clientRequirementsHREntity = new ClientRequirementsHREntity();
                    // Assign values to the entities
                    clientRequirementsHREntity.HrId = 1;
                    clientRequirementsHREntity.ClientId = Convert.ToInt32(txtClientId.Text.Trim()); ;
                    clientRequirementsHREntity.ClientName = txtClientName.Text.Trim();
                    clientRequirementsHREntity.ClientProfile = txtClientProfile.Text.Trim();
                    clientRequirementsHREntity.Position = txtPosition.Text.Trim();
                    clientRequirementsHREntity.Industry = Convert.ToInt32(ddlIndustry.SelectedValue);
                    clientRequirementsHREntity.FunctionalArea = Convert.ToInt32(ddlFunctionalArea.SelectedValue);
                    clientRequirementsHREntity.Address = txtAddress.Text.Trim();
                    clientRequirementsHREntity.CountryId = Convert.ToInt32(ddlCountry.SelectedValue);
                    clientRequirementsHREntity.StateId = Convert.ToInt32(ddlState.SelectedValue);
                    clientRequirementsHREntity.CityId = Convert.ToInt32(ddlCity.SelectedValue);
                    clientRequirementsHREntity.AreaId = Convert.ToInt32(ddlArea.SelectedValue);
                    clientRequirementsHREntity.Pincode = Convert.ToInt32(txtPincode.Text.Trim());
                    clientRequirementsHREntity.Skillsets = txtSkillsets.Text.Trim();
                    clientRequirementsHREntity.Contents = txtContents.Text.Trim();
                    clientRequirementsHREntity.DateOfRequirementSent = Convert.ToDateTime(txtDateofRequirementSent.Text);
                    clientRequirementsHREntity.DueDate = Convert.ToDateTime(txtDueDate.Text);
                    clientRequirementsHREntity.Status = rbtlistStatus.SelectedItem.Text.Trim();
                    clientRequirementsHREntity.RecruiterID = Convert.ToInt32(ddlRecruiter.SelectedValue);

                    // Saving data to the database
                    int result = clientRequirementsHRBAL.UpdateClientRequirementsBAL(clientRequirementsHREntity);
                    if (result > 0)
                    {
                        Response.Write("<script language='javascript'>alert('Update Client Requirement Successfully')</script>");
                    }
                    else
                    {
                        Response.Write("<script language='javascript'>alert('Client Requirement won't Updated')</script>");
                    }
                }
                catch (Exception)
                {
                    //throw;
                }
                BindViewClientRequirements();
            }
            // Check commond for delete
            if (e.CommandName == "delete")
            {
                try
                {
                    //ClientRequirementsHRBAL clientRequirementsHRBAL = new ClientRequirementsHRBAL();
                    //int ClientRequirementId = Convert.ToInt32(e.CommandArgument);
                    //clientRequirementsHRBAL.DeleteclientRequirementsBAL(ClientRequirementId);
                }
                catch (Exception)
                {
                    // throw;
                }
                BindViewClientRequirements();
            }
        }
        protected void rptrClientDetails_ItemCreated(object sender, RepeaterItemEventArgs e)
        {
            //DropDownList rptrddlCountry = (DropDownList)e.Item.FindControl("ddlCountry");
            //rptrddlCountry.SelectedIndexChanged += ddlCountry_SelectedIndexChanged;
        }
        protected void rptrClientDetails_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {   
            DropDownList ddlIndustry = (DropDownList)e.Item.FindControl("ddlIndustry");
            DataSet dsIndustry = null;
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                try
                {
                    ClientRequirementsHRBAL clientRequirementsHRBAL = new ClientRequirementsHRBAL();

                    dsIndustry = clientRequirementsHRBAL.GetIndustry();
                    // Check if dataset is not null
                    if (dsIndustry != null)
                    {
                        ddlIndustry.DataSource = dsIndustry;
                        ddlIndustry.DataTextField = "IndustryName";
                        ddlIndustry.DataValueField = "IndustryId";
                        ddlIndustry.DataBind();
                        ddlIndustry.SelectedValue = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "IndustryId"));
                    }
                }
                catch (Exception)
                {
                    // throw;
                }
            }

            DropDownList ddlFunctionalArea = (DropDownList)e.Item.FindControl("ddlFunctionalArea");
            DataSet dsFunctionalArea = null;
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                try
                {
                    ClientRequirementsHRBAL clientRequirementsHRBAL = new ClientRequirementsHRBAL();

                    dsFunctionalArea = clientRequirementsHRBAL.GetFunctionalArea();
                    // Check if dataset is not null
                    if (dsFunctionalArea != null)
                    {
                        ddlFunctionalArea.DataSource = dsFunctionalArea;
                        ddlFunctionalArea.DataTextField = "FunctionalArea";
                        ddlFunctionalArea.DataValueField = "FunctionalAreaId";
                        ddlFunctionalArea.DataBind();
                        ddlFunctionalArea.SelectedValue = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "FunctionalAreaId"));
                    }
                }
                catch (Exception)
                {
                    // throw;
                }
            }

            DropDownList ddlCountry = (DropDownList)e.Item.FindControl("ddlCountry");
            DataSet dsCountry = null;
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                try
                {
                    ClientRequirementsHRBAL clientRequirementsHRBAL = new ClientRequirementsHRBAL();

                    dsCountry = clientRequirementsHRBAL.GetCountry();
                    // Check if dataset is not null
                    if (dsCountry != null)
                    {
                        ddlCountry.DataSource = dsCountry;
                        ddlCountry.DataTextField = "CountryName";
                        ddlCountry.DataValueField = "CountryId";
                        ddlCountry.DataBind();
                        ddlCountry.SelectedValue = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "CountryId"));
                        //ddlCountry_SelectedIndexChanged(sender, e);
                    }
                }
                catch (Exception)
                {
                    // throw;
                }
                finally
                {
                    //ddlCountry_SelectedIndexChanged(sender, e);
                    //DropDownList ddlState = (DropDownList)repClientDetails.Controls[0].Controls[0].FindControl("ddlState");
                }
            }

            DropDownList ddlState = (DropDownList)e.Item.FindControl("ddlState");
            DataSet dsState = null;
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                try
                {
                    ClientRequirementsHRBAL clientRequirementsHRBAL = new ClientRequirementsHRBAL();

                    //dsCountry = clientRequirementsHRBAL.GetCountry();
                    //ddlCountry = (DropDownList)repClientDetails.Controls[0].Controls[0].FindControl("ddlCountry");
                    DropDownList rptrddlCountry = (DropDownList)e.Item.FindControl("ddlCountry");
                    //rptrddlCountry.SelectedIndexChanged += ddlCountry_SelectedIndexChanged;

                    rptrddlCountry = (DropDownList)e.Item.FindControl("ddlCountry");
                    rptrddlCountry.SelectedValue = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "CountryId"));
                    int countryId = Convert.ToInt32(rptrddlCountry.SelectedValue);
                    dsState = clientRequirementsHRBAL.GetState(countryId);
                    // Check if dataset is not null
                    if (ddlState != null)
                    {
                        ddlState.DataSource = dsState;
                        ddlState.DataTextField = "StateName";
                        ddlState.DataValueField = "StateId";
                        ddlState.DataBind();
                        ddlState.SelectedValue = Convert.ToString(DataBinder.Eval(e.Item.DataItem, "StateId"));
                        //ddlCountry_SelectedIndexChanged(sender, e);
                    }
                }
                catch (Exception)
                {
                    // throw;
                }
            }
           //Private Void BindState(object sender, EventArgs e)
           // {
           //     int countryId = Convert.ToInt32(ddlCountry.SelectedValue);
           //     dsClientDetails = clientRequirementsHRBAL.GetState(countryId);
           //     ddlState.DataSource = dsClientDetails;
           //     ddlState.DataValueField = "StateId";
           //     ddlState.DataTextField = "StateName";
           //     ddlState.DataBind();
           //     ddlState.Items.Insert(0, new ListItem("--Select--", "0"));
           // }
        }


      //  [System.Web.Script.Services.ScriptMethod()]
      //  [System.Web.Services.WebMethod]
      //  public static List<KeyValuePair<int, string>> GetRecruiter(string prefixText, int count)
      //{
      //      DataTable dtRecruiter = new DataTable();

      //      ClientRequirementsHRBAL clientRequirementsHRBAL = new ClientRequirementsHRBAL();
      //      dtRecruiter = clientRequirementsHRBAL.GetRecruiterBAL(prefixText, count);
      //      //List<string> recruitername = new List<string>();
      //      //List<int> recruiterId = new List<int>();

            
      //      var RecruiterList = new List<KeyValuePair<int, string>>();
      //      //RecruiterList.Add(new KeyValuePair<int, string>(1, "One");


      //      int recruiterId; string recruitername;


      //      try
      //      {
      //          // Check datatable is not null
      //          if (dtRecruiter != null)
      //          {
      //              foreach (var item in RecruiterList)
      //              {
      //                  recruiterId = Convert.ToInt16(dtRecruiter.Rows[0]["@RecruiterID"]);
      //                  recruitername = Convert.ToString(dtRecruiter.Rows[0]["@RecruiterfullName"]); ;
      //              }
                    
      //              //for (int i = 0; i < dtRecruiter.Rows.Count; i++)
      //              //{
      //              //    recruitername.Add(dtRecruiter.Rows[i][1].ToString());
      //              //}
      //          }
      //      }
      //      catch (Exception) 
      //      {
      //          //  throw;
      //      }
      //      return RecruiterList;
      //  }

        /// <summary>
        /// Method for binding DropDown with Client_table of database
        /// </summary>
        private void BindClient(long HrId, long ClientId)
        {
            DataSet dsClientDetails = new DataSet();
            dsClientDetails = clientRequirementsHRBAL.GetClientNameBAL(HrId,ClientId);

            txtClientId.Text = dsClientDetails.Tables[0].Rows[0]["ClientId"].ToString();
            txtClientName.Text = dsClientDetails.Tables[0].Rows[0]["ClientName"].ToString();
            txtClientProfile.Text = dsClientDetails.Tables[0].Rows[0]["ClientProfile"].ToString();
        }

        /// <summary>
        /// Method for binding DropDown with Recruiter_table of database
        /// </summary>
        private void BindRecruiter(int HrId)
        {
            HrId = 1;
            dsClientDetails = clientRequirementsHRBAL.GetRecruiterBAL(HrId);
            dsClientDetails.Tables[0].Columns.Add("RecruiterfullNameAndCompany", typeof(string), "RecruiterfullName + ' - ' + Company");
            ddlRecruiter.DataSource = dsClientDetails;
            ddlRecruiter.DataTextField = "RecruiterfullNameAndCompany";
            ddlRecruiter.DataValueField = "RecruiterID";
            ddlRecruiter.DataBind();
        }
        /// <summary>
        /// Method for binding DropDown with FunctionalArea_Table of Database
        /// </summary>
        private void BindFunctionalArea()
        {
            dsClientDetails = clientRequirementsHRBAL.GetFunctionalArea();
            ddlFunctionalArea.DataSource = dsClientDetails;
            ddlFunctionalArea.DataValueField = "FunctionalAreaId";
            ddlFunctionalArea.DataTextField = "FunctionalArea";
            ddlFunctionalArea.DataBind();
            ddlFunctionalArea.Items.Insert(0, new ListItem("--Select--", "0"));

        }

        /// <summary>
        /// Method for binding DropDown with Industry_table of database
        /// </summary>
        private void BindIndustry()
        {
            dsClientDetails = clientRequirementsHRBAL.GetIndustry();
            ddlIndustry.DataSource = dsClientDetails;
            ddlIndustry.DataTextField = "IndustryName";
            ddlIndustry.DataValueField = "IndustryId";
            ddlIndustry.DataBind();
            ddlIndustry.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        /// <summary>
        /// Method for binding Dropdown with Country_table of database
        /// </summary>
        private void BindCountry()
        {
            dsClientDetails = clientRequirementsHRBAL.GetCountry();
            ddlCountry.DataSource = dsClientDetails;
            ddlCountry.DataTextField = "CountryName";
            ddlCountry.DataValueField = "CountryId";
            ddlCountry.DataBind();
            ddlCountry.Items.Insert(0, new ListItem("--Select--", "0"));
        }
        /// <summary>
        /// ddlCountry_SelectedIndexChanged for selection of state on basis of Countryid
        /// </summary>
        /// <param name="sender">The soure of event</param>
        /// <param name="e">The <see cref="EventArgs"/>containing event data</param>
        protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(isEdit)
            {
                Repeater rptr = new Repeater();
                DropDownList rptrddlCountry = (DropDownList)repClientDetails.Controls[0].Controls[0].FindControl("ddlCountry");
                int rptrcountryId = Convert.ToInt32(rptrddlCountry.SelectedValue);
                dsClientDetails = clientRequirementsHRBAL.GetState(rptrcountryId);
                ddlState.DataSource = dsClientDetails;
                ddlState.DataValueField = "StateId";
                ddlState.DataTextField = "StateName";
                ddlState.DataBind();
                ddlState.Items.Insert(0, new ListItem("--Select--", "0"));
            }
            int countryId = Convert.ToInt32(ddlCountry.SelectedValue);
            dsClientDetails = clientRequirementsHRBAL.GetState(countryId);
            ddlState.DataSource = dsClientDetails;
            ddlState.DataValueField = "StateId";
            ddlState.DataTextField = "StateName";
            ddlState.DataBind();
            ddlState.Items.Insert(0, new ListItem("--Select--", "0"));
        }
        /// <summary>
        /// ddlState_SelectedIndexChanged for selection of city on basis of stateid
        /// </summary>
        /// <param name="sender">The soure of event</param>
        /// <param name="e">The <see cref="EventArgs"/>containing event data</param>
        protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {
            int stateId = Convert.ToInt32(ddlState.SelectedValue);
            dsClientDetails = clientRequirementsHRBAL.GetCity(stateId);
            ddlCity.DataSource = dsClientDetails;
            ddlCity.DataValueField = "cityID";
            ddlCity.DataTextField = "cityName";
            ddlCity.DataBind();
            ddlCity.Items.Insert(0, new ListItem("--Select--", "0"));
        }
        /// <summary>
        /// ddlCity_SelectedIndexChanged for selection of city on basis of stateid
        /// </summary>
        /// <param name="sender">The soure of event</param>
        /// <param name="e">The <see cref="EventArgs"/>containing event data</param>
        protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cityId = Convert.ToInt32(ddlCity.SelectedValue);
            dsClientDetails = clientRequirementsHRBAL.GetArea(cityId);
            ddlArea.DataSource = dsClientDetails;
            ddlArea.DataValueField = "areaID";
            ddlArea.DataTextField = "areaName";
            ddlArea.DataBind();
            ddlArea.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        protected void ddlRecruiter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}