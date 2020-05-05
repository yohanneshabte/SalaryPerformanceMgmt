using System;
using System.Data.SqlClient;
using salaryMgmt.DTOs;
using salaryMgmt.Config.Gateway;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace salaryMgmt.Models
{
    [Serializable]
    public class PerformanceReview
    {
        public PositionDTO Position { get; set; }
        public EmployeePerformanceReviewDTO EmpPR { get; set; }
        public PerformanceRatingDTO CurrentPR { get; set; }
        public MeritGuidelinesDTO MeritGuidelines { get; set; }

        private DatabaseGateway db;

        public PerformanceReview(int id)
        {
            Position = new PositionDTO();
            EmpPR = new EmployeePerformanceReviewDTO();
            CurrentPR = new PerformanceRatingDTO();
            MeritGuidelines = new MeritGuidelinesDTO();
            EmpPR.PRDetails = new List<PerformanceReviewDetail>();

            db = new DatabaseGateway();

            SqlDataReader pr = db.GetPR(id);
            while(pr.Read())
            {
                Position.POS_ID = (int)pr.GetSqlInt32(pr.GetOrdinal("pos_id"));
                Position.POS_TITLE = pr.GetString(pr.GetOrdinal("pos_titile"));
                EmpPR.EMP_PER_REV = (int)pr.GetSqlInt32(pr.GetOrdinal("emp_per_rev"));
                EmpPR.PERFORMANCE_FEEDBACK = pr.GetString(pr.GetOrdinal("performance_feedback"));
                EmpPR.PREVIOUS_REVIEW = pr.GetString(pr.GetOrdinal("previos_review"));
                EmpPR.REVIEW_DATE = pr.GetDateTime(pr.GetOrdinal("review_date"));
                CurrentPR.RATING_ID = (int)pr.GetSqlInt32(pr.GetOrdinal("rating_id"));
                CurrentPR.RATING_NAME = pr.GetString(pr.GetOrdinal("rating_name"));
                CurrentPR.RATING_DESC = pr.GetString(pr.GetOrdinal("rating_desc"));
                MeritGuidelines.MERIT_ID = (int)pr.GetSqlInt32(pr.GetOrdinal("merit_id"));
                MeritGuidelines.RAISE_TARGET = (float)pr.GetDouble(pr.GetOrdinal("raise_target"));
                MeritGuidelines.RAISE_MIN = (float)pr.GetDouble(pr.GetOrdinal("raise_min"));
                MeritGuidelines.RAISE_MAX = (float)pr.GetDouble(pr.GetOrdinal("raise_max"));

                PerformanceReviewDetail PRDetailCurrent = new PerformanceReviewDetail(EmpPR.EMP_PER_REV);

                EmpPR.PRDetails.Add(PRDetailCurrent);
            }

        }
    }
    [Serializable]
    public class PerformanceReviewDetail
    {
        [JsonProperty(PropertyName = "Test")]
        public List<PRDetailDTO> PRDetailList { get; set; }

        private DatabaseGateway db;

        public PerformanceReviewDetail(int prID)
        {
            PRDetailList = new List<PRDetailDTO>(); 

            db = new DatabaseGateway();

            SqlDataReader prd = db.GetPRDetail(prID);
            while(prd.Read())
            {
                PRDetailDTO PRDetail = new PRDetailDTO();

                PRDetail.PR_DETAIL_ID = (int)prd.GetSqlInt32(prd.GetOrdinal("pr_detail_id"));
                PRDetail.EMP_PER_REV = (int)prd.GetSqlInt32(prd.GetOrdinal("emp_per_rev"));
                PRDetail.FACTOR_NAME = prd.GetString(prd.GetOrdinal("factor_name"));
                PRDetail.FACTOR_DIMENSIONS = prd.GetString(prd.GetOrdinal("factor_dimensions"));
                PRDetail.FACTOR_CATEGORY = prd.GetString(prd.GetOrdinal("factor_catagory"));
                PRDetail.RATING_NAME = prd.GetString(prd.GetOrdinal("factor_name"));

                PRDetailList.Add(PRDetail);
            }
        }
    }
}
