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
                Position.posTitle = pr.GetString(pr.GetOrdinal("pos_titile"));
                EmpPR.EMP_PER_REV = (int)pr.GetSqlInt32(pr.GetOrdinal("emp_per_rev"));
                EmpPR.performanceFeedback = pr.GetString(pr.GetOrdinal("performance_feedback"));
                EmpPR.previousReview = pr.GetString(pr.GetOrdinal("previos_review"));
                EmpPR.reviewDate = pr.GetDateTime(pr.GetOrdinal("review_date"));
                CurrentPR.RATING_ID = (int)pr.GetSqlInt32(pr.GetOrdinal("rating_id"));
                CurrentPR.ratingName = pr.GetString(pr.GetOrdinal("rating_name"));
                CurrentPR.ratingDesc = pr.GetString(pr.GetOrdinal("rating_desc"));
                MeritGuidelines.MERIT_ID = (int)pr.GetSqlInt32(pr.GetOrdinal("merit_id"));
                MeritGuidelines.raiseTarget = (float)pr.GetDouble(pr.GetOrdinal("raise_target"));
                MeritGuidelines.raiseMin = (float)pr.GetDouble(pr.GetOrdinal("raise_min"));
                MeritGuidelines.raiseMax = (float)pr.GetDouble(pr.GetOrdinal("raise_max"));

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
                PRDetail.factorName = prd.GetString(prd.GetOrdinal("factor_name"));
                PRDetail.factorDimensionS = prd.GetString(prd.GetOrdinal("factor_dimensions"));
                PRDetail.factorCategory = prd.GetString(prd.GetOrdinal("factor_catagory"));
                PRDetail.ratingName = prd.GetString(prd.GetOrdinal("factor_name"));

                PRDetailList.Add(PRDetail);
            }
        }
    }
}
