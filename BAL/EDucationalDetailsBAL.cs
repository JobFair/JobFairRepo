using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.JobSeeker;
using DAL;
using System.Data;
using CommonUtil;

namespace BAL
{
   public class EducationalDetailsBAL
    {
            /// <summary>
            /// Saving Educational Deatils JobSeeker.
            /// </summary>
            /// <param name="edEntity">The Educational Details entity.</param>
            /// <returns>System.Int32.</returns>
           public bool SaveEducationalDetailsBAL(List<EducationalDetailsEntity> edEntity)
           {
               EducationalDetailsDAL edDAL = new EducationalDetailsDAL();
               return edDAL.SaveEducationalDetailsDAL(edEntity);
           }
           /// <summary>
           /// Selecting Educational Deatils JobSeeker.
           /// </summary>
           /// <param name="edEntity">The Educational Details entity.</param>
           /// <returns>System.Int32.</returns>
           public DataSet SelectEducationalDetailsBAL(string candidateId, int degreeId, int specializationId)
           {
               EducationalDetailsDAL educationalDetailsDAL = new EducationalDetailsDAL();
               return educationalDetailsDAL.SelectEducationalDetailsDAL(candidateId, degreeId, specializationId);
           }

            /// <summary>
            /// Updating Educational Deatils JobSeeker.
            /// </summary>
            /// <param name="edEntity">The Educational Details entity.</param>
            /// <returns>System.Int32.</returns>
           public int UpdateEducationalDetailsBAL(Entities.JobSeeker.EducationalDetailsEntity educationalDetailsEntity)
           {
               EducationalDetailsDAL updateEdDAL = new EducationalDetailsDAL();
               return updateEdDAL.UpdateEducationalDetailsDAL(educationalDetailsEntity);
           }

           /// <summary>
           /// Load Educational Degree Type
           /// </summary>
           /// <returns></returns>
           public DataSet GetEducationalDegreeTypeBAL()
           {
               return Utility.GetEducationalDegreeTypeDAL();
           }

           public DataSet GetEducationalDegreeTypeBAL(string CandidateId)
           {
               return Utility.GetEducationalDegreeTypeDAL(CandidateId);
           }

           /// <summary>
           /// Load Degree Details
           /// </summary>
           /// <returns></returns>
           public DataSet GetDegreeDetailsBAL(int DegreeId)
           {
               return Utility.GetDegreeDetails(DegreeId);
           }

           /// <summary>
           /// Load Educational Degree Type
           /// </summary>
           /// <returns></returns>
           public DataSet GetLanguageBAL()
           {
               return Utility.GetLanguage();
           }

           /// <summary>
           /// To add functional area method in EducationalDetailsBAL class
           /// </summary>
           /// <param name="educationalDetailsEntity">Object of EducationalDetailsEntity </param>
           public void AddUnderGraduateDiplomaBAL(Entities.JobSeeker.EducationalDetailsEntity educationalDetailsEntity)
           {
               EducationalDetailsDAL educationalDetailsDAL = new EducationalDetailsDAL();
               educationalDetailsDAL.AddUnderGraduateDiplomaDAL(educationalDetailsEntity);
           }
           /// <summary>
           /// To add BachelorDegree method in EducationalDetailsBAL class
           /// </summary>
           /// <param name="educationalDetailsEntity">Object of EducationalDetailsEntity </param>
           public void AddBachelorDegreeBAL(Entities.JobSeeker.EducationalDetailsEntity educationalDetailsEntity)
           {
               EducationalDetailsDAL educationalDetailsDAL = new EducationalDetailsDAL();
               educationalDetailsDAL.AddBachelorDegreeDAL(educationalDetailsEntity);
           }
           /// <summary>
           /// To add PostGraduateDiploma method in EducationalDetailsBAL class
           /// </summary>
           /// <param name="educationalDetailsEntity">Object of EducationalDetailsEntity </param>
           public void AddPostGraduateDiplomaBAL(Entities.JobSeeker.EducationalDetailsEntity educationalDetailsEntity)
           {
               EducationalDetailsDAL educationalDetailsDAL = new EducationalDetailsDAL();
               educationalDetailsDAL.AddPostGraduateDiplomaDAL(educationalDetailsEntity);
           }
           /// <summary>
           /// To add MasterDegree method in EducationalDetailsBAL class
           /// </summary>
           /// <param name="educationalDetailsEntity">Object of EducationalDetailsEntity </param>
           public void AddMasterDegreeBAL(Entities.JobSeeker.EducationalDetailsEntity educationalDetailsEntity)
           {
               EducationalDetailsDAL educationalDetailsDAL = new EducationalDetailsDAL();
               educationalDetailsDAL.AddMasterDegreeDAL(educationalDetailsEntity);
           }
           /// <summary>
           /// To add DoctorOfPhilosophy method in EducationalDetailsBAL class
           /// </summary>
           /// <param name="educationalDetailsEntity">Object of EducationalDetailsEntity </param>
           public void AddPHDBAL(Entities.JobSeeker.EducationalDetailsEntity educationalDetailsEntity)
           {
               EducationalDetailsDAL educationalDetailsDAL = new EducationalDetailsDAL();
               educationalDetailsDAL.AddPHDDAL(educationalDetailsEntity);
           }
       }
    }

