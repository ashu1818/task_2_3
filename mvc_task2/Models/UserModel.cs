using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvc_task2.Models
{
    public class UserModel
    {
        public UserModel() { }
        public UserModel(int id, string name, string emailid, string mob, string pass, string gender, string url, int sid)
        {
            
            this.UserId = id;
            this.UserName = name;
            this.EmailId = emailid;
            this.MobileNumber = mob;
            this.Password = pass;
            this.Gender = gender;
            this.UserImageUrl = url;
            this.StateId = new StateModel() { StateId = sid };
           // this.StateId.CountryId = new CountryModel();

            
        }
          
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage = "Enter User Name!")]
        [Display(Name = "User Name*")]
        public  string UserName { get; set; }
        [Required(ErrorMessage = "Enter User Name!")]
        [Display(Name = "User Name*")]
        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }
        [Required(ErrorMessage = "Enter User Name!")]
        [Display(Name = "User Name*")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Enter User Name!")]
        [Display(Name = "User Name*")]
        [Compare("Password",ErrorMessage = "Not match")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Enter User Number!")]
        [Display(Name = "User Mobile Number*")]
        public string MobileNumber { get; set; }
        public string UserImageUrl { get; set; }
        public string Gender { get; set; }

        public StateModel StateId { get; set; }

        public List<StateModel> GetStates { get
            {
                return new List<StateModel>()
                {
                    new StateModel()
                    {
                        StateId = 1,
                        StateName = "Gujarat"

                    },
                    new StateModel()
                    {
                        StateId = 2,
                        StateName = "NYC"
                    }
                    
                };
            } }
    }
}