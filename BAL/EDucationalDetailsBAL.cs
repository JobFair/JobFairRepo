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
           public DataSet ViewEducationalDetailsBAL(string candidateId)
           {
               EducationalDetailsDAL educationalDetailsDAL = new EducationalDetailsDAL();
               return educationalDetailsDAL.ViewEducationalDetailsDAL(candidateId);
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
           /// <summary>
           /// Load Under Graduate Diploma
           /// </summary>
           /// <returns></returns>
           public DataSet GetUnderGraduateDiplomaBAL()
           {
               return Utility.GetUnderGraduateDiplomaDAL();
           }
           /// <summary>
           /// Load Bachelor Degree
           /// </summary>
           /// <returns></returns>
           public DataSet GetBachelorDegreeBAL()
           {
               return Utility.GetBachelorDegreeDAL();
           }
           /// <summary>
           /// Load Post Graduate Diploma
           /// </summary>
           /// <returns></returns>
           public DataSet GetPostGraduateDiplomaBAL()
           {
               return Utility.GetPostGraduateDiplomaDAL();
           }
           /// <summary>
           /// Load Master Degree
           /// </summary>
           /// <returns></returns>
           public DataSet GetMasterDegreeBAL()
           {
               return Utility.GetMasterDegreeDAL();
           }
           /// <summary>
           /// Load Doctor Of Philosophy
           /// </summary>
           /// <returns></returns>
           public DataSet GetDoctorOfPhilosophyBAL()
           {
               return Utility.GetDoctorOfPhilosophyDAL();
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
           public void AddDoctorOfPhilosophyBAL(Entities.JobSeeker.EducationalDetailsEntity educationalDetailsEntity)
           {
               EducationalDetailsDAL educationalDetailsDAL = new EducationalDetailsDAL();
               educationalDetailsDAL.AddDoctorOfPhilosophyDAL(educationalDetailsEntity);
           }
       }
    }

