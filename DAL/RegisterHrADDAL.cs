using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RegisterHrADDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        public string SaveNewHrDAL(Entities.Common.RegisterEntity registerEntity)
        {
            try
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                SqlParameter[] param = new SqlParameter[26];
                param[0] = new SqlParameter("@recrName", registerEntity.FullName);
                param[1] = new SqlParameter("@company", registerEntity.Company);
                param[2] = new SqlParameter("@officialContactNo", registerEntity.OfficialContactNo);
                param[3] = new SqlParameter("@mobNo", registerEntity.MobileNo);
                param[4] = new SqlParameter("@alternateNo", registerEntity.AlternateNo);
                param[5] = new SqlParameter("@officialEmailid", registerEntity.OfficialEmailId);
                param[6] = new SqlParameter("@personalMailId", registerEntity.PersonalMailId);
                param[7] = new SqlParameter("@freelancerOrEmployee", registerEntity.FreelanceOrEmployee);
                param[8] = new SqlParameter("@amountPerMonth", registerEntity.AmountPerMonth);
                param[9] = new SqlParameter("@percentPerClosure", registerEntity.PercentPerClosure);
                param[10] = new SqlParameter("@employeeSalary", registerEntity.EmployeeSalary);
                param[11] = new SqlParameter("@address", registerEntity.Address);
                param[12] = new SqlParameter("@presentCountry", registerEntity.PresentCountry);
                param[13] = new SqlParameter("@presentState", registerEntity.PresentState);
                param[14] = new SqlParameter("@presentCity", registerEntity.PresentCity);
                param[15] = new SqlParameter("@presentArea", registerEntity.PresentArea);
                param[16] = new SqlParameter("@pinCode", registerEntity.Pincode);
                param[17] = new SqlParameter("@employmentStatus", registerEntity.EmploymentStatus);
                param[18] = new SqlParameter("@jobType", registerEntity.JobType);
                param[19] = new SqlParameter("@clientSite", registerEntity.ClientSite);
                param[20] = new SqlParameter("@clientName", registerEntity.ClientName);
                param[21] = new SqlParameter("@panCardNo", registerEntity.PANCardNo);
                param[22] = new SqlParameter("@photoPath", registerEntity.PhotoPath);
                param[23] = new SqlParameter("@password", registerEntity.Password);
                param[24] = new SqlParameter("@isMailSent", registerEntity.IsMailSent);
                param[25] = new SqlParameter("@setHrid", SqlDbType.VarChar, 500);
                param[25].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_AD_InsertHRRegisterDetails, param);
                string recruiterID = Convert.ToString(param[25].Value);

                if (string.IsNullOrEmpty(recruiterID))
                {
                    return null;
                }
                return recruiterID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public void UpdateMailsentDAL(Entities.Common.RegisterEntity registerEntity)
        {
            try
            {
                connection.Open();
                SqlParameter[] sparams = new SqlParameter[2];
                sparams[0] = new SqlParameter("@hrID", registerEntity.Recruiterid);
                sparams[1] = new SqlParameter("@isMailsent", registerEntity.IsMailSent);
                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_AD_UpdateHrIsMailSent, sparams);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
