﻿using Entities.HR;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System;

namespace DAL
{
    /// <summary>
    /// Class ClientDetailsDAL
    /// </summary>
    public class ClientDetailsDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// Method of class ClientDetailsDAL for saving ClientDetails in database
        /// </summary>
        /// <param name="clientdetailsEntity">Object of ClientDetailsEntity</param>
        /// <returns>System.Int32</returns>
        public int SaveClientDetailsDAL(ClientDetailsEntity clientdetailsEntity)
        {
            try
            {
                connection.Open();
                //Add parameter for stored procedure                
                SqlParameter[] sparam = { new SqlParameter("@hrid", clientdetailsEntity.HrId),
                                          new SqlParameter("@clientName", clientdetailsEntity.ClientName),
                                          new SqlParameter("@clientProfile", clientdetailsEntity.ClientProfile),
                                          new SqlParameter("@industry", clientdetailsEntity.Industry),
                                          new SqlParameter("@functuionalarea", clientdetailsEntity.FunctionalArea),
                                          new SqlParameter("@address", clientdetailsEntity.Address),
                                          new SqlParameter("@countryId", clientdetailsEntity.CountryId),
                                          new SqlParameter("@stateId", clientdetailsEntity.StateId),
                                          new SqlParameter("@cityId", clientdetailsEntity.CityId),
                                          new SqlParameter("@areaId", clientdetailsEntity.AreaId),
                                          new SqlParameter("@pincode", clientdetailsEntity.Pincode),
                                          new SqlParameter("@officialEmailId", clientdetailsEntity.OfficialEmailId),
                                          new SqlParameter("@website", clientdetailsEntity.Website),
                                          new SqlParameter("@officialContact", clientdetailsEntity.OfficialContact),
                                          new SqlParameter("@status", clientdetailsEntity.Status),
                                          new SqlParameter("@agreementDate", clientdetailsEntity.AgreementDate.Date),
                                          new SqlParameter("@dueDate", clientdetailsEntity.DueDate.Date),
                                          new SqlParameter("@paymentDetails", clientdetailsEntity.PaymentDetails),
                                          new SqlParameter("@paymentTerms", clientdetailsEntity.PaymentTerms),
                                          new SqlParameter("@percentageAmount", clientdetailsEntity.PercentageAmount)
                                        };
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_HR_InsertClientDetails, sparam);
                return result;
            }
            catch (System.Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Method of class ClientDetailsDAL for Updating ClientDetails in database
        /// </summary>
        /// <param name="clientdetailsEntity">Object of ClientDetailsEntity</param>
        /// <returns>System.Int32</returns>
        public int UpdateClientDetailsDAL(ClientDetailsEntity clientdetailsEntity)
        {
            try
            {
                connection.Open();
                //Add parameter for stored procedure                
                SqlParameter[] sparam = { new SqlParameter("@clientid", clientdetailsEntity.ClientId),
                                          new SqlParameter("@hrid", clientdetailsEntity.HrId),
                                          //new SqlParameter("@clientName", clientdetailsEntity.ClientName),
                                          new SqlParameter("@clientProfile", clientdetailsEntity.ClientProfile),
                                          new SqlParameter("@industry", clientdetailsEntity.Industry),
                                          new SqlParameter("@functuionalarea", clientdetailsEntity.FunctionalArea),
                                          new SqlParameter("@address", clientdetailsEntity.Address),
                                          new SqlParameter("@countryId", clientdetailsEntity.CountryId),
                                          new SqlParameter("@stateId", clientdetailsEntity.StateId),
                                          new SqlParameter("@cityId", clientdetailsEntity.CityId),
                                          new SqlParameter("@areaId", clientdetailsEntity.AreaId),
                                          new SqlParameter("@pincode", clientdetailsEntity.Pincode),
                                          new SqlParameter("@officialEmailId", clientdetailsEntity.OfficialEmailId),
                                          new SqlParameter("@website", clientdetailsEntity.Website),
                                          new SqlParameter("@officialContact", clientdetailsEntity.OfficialContact),
                                          new SqlParameter("@status", clientdetailsEntity.Status),
                                          new SqlParameter("@agreementDate", clientdetailsEntity.AgreementDate.Date),
                                          new SqlParameter("@dueDate", clientdetailsEntity.DueDate.Date),
                                          new SqlParameter("@paymentDetails", clientdetailsEntity.PaymentDetails),
                                          new SqlParameter("@paymentTerms", clientdetailsEntity.PaymentTerms),
                                          new SqlParameter("@percentageAmount", clientdetailsEntity.PercentageAmount)
                                        };
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_HR_UpdateClientDetails, sparam);
                return result;
            }
            catch (System.Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Method for adding Functional Details in database
        /// </summary>
        /// <param name="clientDetailsEntity">Object of ClientDetailsEntity</param>
        public void AddFunctionalDAL(ClientDetailsEntity clientDetailsEntity)
        {
            try
            {
                connection.Open();
                SqlParameter[] sparams = new SqlParameter[1];
                //Add parameter for stored procedure
                sparams[0] = new SqlParameter("@FunctionalareaName", clientDetailsEntity.AddFunctionalArea);
                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_RE_InsertFunctionalArea, sparams);
            }
            catch (System.Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        /// <summary>
        /// Method of class ClientDetailsDAL for Viewing ClientDetails in database
        /// </summary>
        public DataSet ViewClientDetailsDAL(long clientId, long HrId)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlParameter[] sparams = {
                                             new SqlParameter("@clientId", clientId),
                                             new SqlParameter("@hrId",HrId)
                                         };
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_HR_ViewClientDetails, sparams);
            }
            catch (Exception)
            {
                throw;
            }
            return ds;
        }
    }
}