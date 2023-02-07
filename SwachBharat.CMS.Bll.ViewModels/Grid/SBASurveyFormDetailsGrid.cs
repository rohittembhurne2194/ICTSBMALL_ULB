using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwachBharat.CMS.Bll.ViewModels.Grid
{
    public class SBASurveyFormDetailsGrid
    {
        public int svId { get; set; }
        public int houseId { get; set; }
        public string ReferanceId { get; set; }
        public string houseLat { get; set; }
        public string houseLong { get; set; }
        public string name { get; set; }
        public string mobileNumber { get; set; }
        public Nullable<int> age { get; set; }
        public Nullable<System.DateTime> dateOfBirth { get; set; }
        public string strDateOfBirth { get; set; }
        public string gender { get; set; }
        public string bloodGroup { get; set; }
        public string qualification { get; set; }
        public string occupation { get; set; }
        public string maritalStatus { get; set; }
        public Nullable<System.DateTime> marriageDate { get; set; }
        public string strMarriageDate { get; set; }
        public string livingStatus { get; set; }
        public Nullable<int> totalMember { get; set; }
        public Nullable<bool> willingStart { get; set; }
        public string strWillingStart { get; set; }
        public Nullable<bool> memberJobOtherCity { get; set; }
        public string strMemberJobOtherCity { get; set; }
        public Nullable<int> noOfVehicle { get; set; }
        public string vehicleType { get; set; }
        public Nullable<int> twoWheelerQty { get; set; }
        public Nullable<int> threeWheelerQty { get; set; }
        public Nullable<int> fourWheelerQty { get; set; }
        public Nullable<int> noPeopleVote { get; set; }
        public string socialMedia { get; set; }
        public string onlineShopping { get; set; }
        public string paymentModePrefer { get; set; }
        public string onlinePayApp { get; set; }
        public string insurance { get; set; }
        public Nullable<bool> underInsurer { get; set; }
        public string strUnderInsurer { get; set; }
        public Nullable<bool> ayushmanBeneficiary { get; set; }
        public string strAyushmanBeneficiary { get; set; }
        public Nullable<bool> boosterShot { get; set; }
        public string strBoosterShot { get; set; }
        public Nullable<bool> memberDivyang { get; set; }
        public string strMemberDivyang { get; set; }
        public Nullable<int> createUserId { get; set; }
        public string createUserName { get; set; }
        public Nullable<System.DateTime> createDate { get; set; }
        public string strCreateDate { get; set; }
        public Nullable<int> updateUserId { get; set; }
        public string updateUserName { get; set; }
        public Nullable<System.DateTime> updateDate { get; set; }
        public string strUpdateDate { get; set; }
        public string resourcesAvailable { get; set; }
        public Nullable<int> totalAdults { get; set; }
        public Nullable<int> totalChildren { get; set; }
        public Nullable<int> totalSrCitizen { get; set; }
        public int totalRowCount { get; set; }

    }
}
