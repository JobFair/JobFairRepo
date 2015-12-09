
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Webform1.aspx.cs" Inherits="JobFair.Forms.JobSeeker.WebForm1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="~/UserControls/Recruiter/ClientDetails.ascx" TagPrefix="uc1" TagName="ClientDetails" %>










<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 108px;
        }
    </style>
</head>
<body>
    <div>
        <table>
            <tr>
                <td>
               <img src="../../Images/logoitch.jpg" alt="Mountain View" style="width:304px;height:228px;" />
                     Apply Confirmation
                    <p>
                         Stop worrying about remembering your username
                    Simply login to <a href="Forms/JobSeeker/LogIn.aspx"></a>with your Email ID!
                    </p>
                    <p>
                          Please add <a href ="info@logosjobfair.co.in"></a> to your contact list
                    to prevent future mails from going into junk Spam folder.
                    </p>   
                      
                    <p>
                              Dear [CandidateID]
                    </p>
                    <p>

                          You have applied to through Logos Job Fair [date]
                    </p>
                      <p>
                        Your job application has been sent to Logos Job Fair.

                        Logos Solutions shall process your details as soon as possible.
                        To review the process of your application, kindly Login on Jobseeker zone on logosjobfair.co.in.
                        Your application history will be shown in the Job Application Section.

                        To view the job details at<a href="www.logosjobfair.co.in "> </a> click<a href="here"></a>

                        Thank you for your interest,

                        Logos Solutions
                    </p>
                </td>
            </tr>
        </table>
    </div>
</body>
</html>
