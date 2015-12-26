﻿namespace DAL
{
    //Contains all stored procedure of database
    public static class Constants
    {
        public const string sp_JS_InsertRegisterUser = "sp_JS_InsertRegisterUser";
        public const string sp_ChangePassword = "sp_ChangePassword";
        public const string sp_JS_InsertContactDetails = "sp_JS_InsertContactDetails";
        public const string sp_LoginRecruiter = "sp_LoginRecruiter";
        public const string sp_Login = "sp_Login";
        public const string sp_FunctionalArea = "sp_FunctionalArea";
        public const string sp_JS_InsertPersonalDetails = "sp_JS_InsertPersonalDetails";
        public const string sp_ForgetPassword = "sp_ForgetPassword";
        public const string sp_JS_insertfeedback = "sp_JS_insertfeedback";
        public const string sp_JS_InsertDesiredJobDetails = "sp_JS_InsertDesiredJobDetails";
        public const string sp_JS_InsertProjectDetails = "sp_JS_InsertProjectDetails";
        public const string SP_Insert_MultipleRows = "SP_Insert_MultipleRows";
        public const string sp_JS_InsertEducationalDetails = "sp_JS_InsertEducationalDetails";
        public const string sp_JS_SelectEducationalDetails = "sp_JS_SelectEducationalDetails";
        public const string sp_JS_UpdateEducationalDetails = "sp_JS_UpdateEducationalDetails";
        public const string sp_JS_InsertEducationDegreesType = "sp_JS_InsertEducationDegreesType";
        public const string sp_JS_InsertMoreCertification = "sp_JS_InsertMoreCertification";
        public const string sp_JS_InsertMoreWorkshop = "sp_JS_InsertMoreWorkshop";
        public const string sp_RE_InsertCloneJob = "sp_RE_InsertCloneJob";
        public const string sp_Country = "sp_Country";
        public const string sp_JS_OtherDetails = "sp_JS_OtherDetails";
        public const string sp_State = "sp_State";
        public const string sp_City = "sp_City";
        public const string sp_JS_InsertResumeFormatting = "sp_JS_InsertResumeFormatting";
        public const string sp_upgraddiagrams = "sp_upgraddiagrams";
        public const string sp_helpdiagrams = "sp_helpdiagrams";
        public const string sp_helpdiagramdefinition = "sp_helpdiagramdefinition";
        public const string sp_creatediagram = "sp_creatediagram";
        public const string sp_renamediagram = "sp_renamediagram";
        public const string sp_alterdiagram = "sp_alterdiagram";
        public const string sp_dropdiagram = "sp_dropdiagram";
        public const string sp_JS_InsertAdvanceSearch = "sp_JS_InsertAdvanceSearch";
        public const string sp_RE_InsertJobPost = "sp_RE_InsertJobPost";
        public const string sp_InsertJobPostHistory = "sp_InsertJobPostHistory";
        public const string sp_JS_InsertProfessionalDetails = "sp_JS_InsertProfessionalDetails";
        public const string sp_UserCredentials = "sp_UserCredentials";
        public const string sp_RE_InsertRegisterDetails = "sp_RE_InsertRegisterDetails";
        public const string sp_RE_UpdateJobPost = "sp_RE_UpdateJobPost";
        public const string sp_InsertLanguageDetails = "sp_InsertLanguageDetails";
        public const string sp_JS_InsertLanguageDetails = "sp_JS_InsertLanguageDetails";
        public const string sp_Industry = "sp_Industry";
        public const string sp_Department = "sp_Department";
        public const string sp_JS_LiveProjectDetails = "sp_JS_LiveProjectDetails";
        public const string sp_RE_insertQuestionrie = "sp_RE_insertQuestionrie";
        public const string sp_RE_SelectViewJobPost = "sp_RE_SelectViewJobPost";
        public const string sp_JS_InsertResumeFormating = "sp_JS_InsertResumeFormating";
        public const string sp_Area = "sp_Area";
        public const string sp_JS_InsertAcademicProjectDetails = "sp_JS_InsertAcademicProjectDetails";
        public const string sp_JS_InsertJobDetails = "sp_JS_InsertJobDetails";
        public const string sp_JS_SelectPersonalDetails = "sp_JS_SelectPersonalDetails";
        public const string sp_JS_SelectContactDetails = "sp_JS_SelectContactDetails";
        public const string sp_JS_UpdateContactDetails = "sp_JS_UpdateContactDetails";
        public const string sp_JS_SelectCurrentDesiredJobDetails = "sp_JS_SelectCurrentDesiredJobDetails";
        public const string sp_JS_UpdatePersonalDetails = "sp_JS_UpdatePersonalDetails";
        public const string sp_JS_SelectAffirmativeDetails = "sp_JS_SelectAffirmativeDetails";
        public const string sp_JS_UpdateAffirmativeDetails = "sp_JS_UpdateAffirmativeDetails";
        public const string sp_JS_UpdateLanguageDetails = "sp_JS_UpdateLanguageDetails";
        public const string sp_JS_SelectProjectDetails = "sp_JS_SelectProjectDetails";
        public const string sp_JS_UpdateProjectDetails = "sp_JS_UpdateProjectDetails";
        public const string sp_JS_DeleteProjectDetails = "sp_JS_DeleteProjectDetails";
        public const string sp_FunctionalRoles = "sp_FunctionalRoles";
        public const string sp_JS_ViewProfile = "sp_JS_ViewProfile";
        public const string sp_JS_SelectTechnicalSkills = "sp_JS_SelectTechnicalSkills";
        public const string sp_JS_SelectCurrentPastJobDeatails = "sp_JS_SelectCurrentPastJobDeatails";
        public const string sp_JS_SelectJobPostLookingFor = "sp_JS_SelectJobPostLookingFor";
        public const string sp_JS_DeleteJobPostLookingFor = "sp_JS_DeleteJobPostLookingFor";
        public const string sp_JS_UpdateJobPostLookingFor = "sp_JS_UpdateJobPostLookingFor";
        public static string sp_JS_UpdateCurrentPastExpDetails = "sp_JS_UpdateCurrentPastExpDetails";
        public static string sp_JS_DeleteCurrentPastJobDetails = "sp_JS_DeleteCurrentPastJobDetails";
        public static string sp_JS_UpdateTechnicalSkills = "sp_JS_UpdateTechnicalSkills";
        public static string sp_JS_DeleteTechnicalSkill = "sp_JS_DeleteTechnicalSkill";
        public static string sp_JS_SelectRoleSkills = "sp_JS_SelectRoleSkills";
        public static string sp_JS_UpdateRoleSkills = "sp_JS_UpdateRoleSkills";
        public static string sp_JS_DeleteRoleSkill = "sp_JS_DeleteRoleSkill";
        public static string sp_JS_SelectRegisterDetails = "sp_JS_SelectRegisterDetails";
        public static string sp_JS_SelectLoginDetails = "sp_JS_SelectLoginDetails";
        public static string sp_JS_ChangePrimaryMailID = "sp_JS_ChangePrimaryMailID";
        public static string sp_JS_ChangePrimaryMobileNo = "sp_JS_ChangePrimaryMobileNo";
        public static string sp_JS_ChangeEmailId = "sp_JS_ChangeEmailId";
        public static string sp_JS_ChangeMobileNo = "sp_JS_ChangeMobileNo";
        public static string sp_RE_InsertClientDetails = "sp_RE_InsertClientDetails";
        public static string sp_RE_InsertFunctionalArea = "sp_RE_InsertFunctionalArea";
        public static string sp_RE_SelectClients = "sp_RE_SelectClients";
        public static string sp_JS_ViewEducationalDetails = "sp_JS_ViewEducationalDetails";
        public static string sp_JS_SelectMoreWorkshop = "sp_JS_SelectMoreWorkshop";
        public static string sp_JS_SelectCertification = "sp_JS_SelectCertification";
        public static string sp_JS_InsertRoleSkill = "sp_JS_InsertRoleSkill";
        public static string sp_JS_InsertTechnicalSkills = "sp_JS_InsertTechnicalSkills";
        public static string sp_InsertJobHistory = "sp_InsertJobHistory";


    }
}