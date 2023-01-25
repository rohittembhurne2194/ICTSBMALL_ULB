using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwachBharat.CMS.Bll.ViewModels.ChildModel.Model
{
    public class SurveyDetailVM:BaseVM
    {
        public int svId { get; set; }
        public int houseId { get; set; }
        public string ReferanceId { get; set; }
        public string houseLat { get; set; }
        public string houseLong { get; set; }
        public string name { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public string mobileNumber { get; set; }
        public Nullable<int> age { get; set; }
        public string dateOfBirth { get; set; }
        public string gender { get; set; }
        public string bloodGroup { get; set; }
        public string qualification { get; set; }
        public string occupation { get; set; }
        public string maritalStatus { get; set; }
        public Nullable<System.DateTime> marriageDate { get; set; }
        public string livingStatus { get; set; }
        public Nullable<int> totalMember { get; set; }
        public Nullable<bool> willingStart { get; set; }
        public Nullable<bool> memberJobOtherCity { get; set; }
        public Nullable<int> noOfVehicle { get; set; }
        public string vehicleType { get; set; }
        public Nullable<int> twoWheelerQty { get; set; }
        public Nullable<int> threeWheelerQty { get; set; }
        public Nullable<int> fourWheelerQty { get; set; }
        public Nullable<int> noPeopleVote { get; set; }
        public string socialMedia { get; set; }
        public List<socialMedia> socialMedialst { get; set; }
        public string onlineShopping { get; set; }
        public List<shopApp> shopApplst { get; set; }
        public string paymentModePrefer { get; set; }
        public string onlinePayApp { get; set; }
        public List<paymentApp> payApplst { get; set; }

        public string insurance { get; set; }
        public Nullable<bool> underInsurer { get; set; }
        public Nullable<bool> ayushmanBeneficiary { get; set; }
        public Nullable<bool> boosterShot { get; set; }
        public Nullable<bool> memberDivyang { get; set; }
        public Nullable<int> createUserId { get; set; }
        public Nullable<System.DateTime> createDate { get; set; }
        public Nullable<int> updateUserId { get; set; }
        public Nullable<System.DateTime> updateDate { get; set; }
        public string resourcesAvailable { get; set; }
        public Nullable<int> totalAdults { get; set; }
        public Nullable<int> totalChildren { get; set; }
        public Nullable<int> totalSrCitizen { get; set; }
    }

    public class socialMedia
    {
        public string socialMediaName { get; set; }
        public bool IsSelected { get; set; }
    }

    public class shopApp
    {
        public string shopAppName { get; set; }
        public bool IsSelected { get; set; }
    }

    public class paymentApp
    {
        public string paymentAppName { get; set; }
        public bool IsSelected { get; set; }
    }
}
