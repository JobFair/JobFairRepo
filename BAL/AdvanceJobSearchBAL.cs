﻿using CommonUtil;
using DAL;
using Entities.Recruiter;
namespace BAL
{
    public class AdvanceJobSearchBAL
    {
        /// <summary>
        /// create method in BAL
        /// </summary>
        /// <returns></returns>
        public static object GetIndustry()
        {
            return Utility.GetIndustry();
        }
    }
}