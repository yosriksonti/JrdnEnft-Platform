using PIkindergarten.Models.admin;
using PIkindergarten.Models.daycare;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PIkindergarten.Models.doctor
{
    public class Doctor : ProfilAdmin
    {
        public bool isActive { get; set; }

        public virtual Daycare daycare { get; set; }
        public ICollection<HealthRecord> healthRecords { get; set; }

        public ICollection<DoctorAvailability> availabilities { get; set; }
        public Doctor()
        {

        }

        public Doctor(int id, string name , string lastname , 
            string email , string address , 
            string password,string image ,
            string cin,string login,
            int phone,DateTime birth,
            RoleAdmin role,bool isActive,
            Daycare daycare, ICollection<HealthRecord> healthRecords,
            ICollection<DoctorAvailability> availabilities

            )
        {
            this.id = id;
            this.Name = name;
            this.Lastname = lastname;
            this.Email = email;
            this.Address = address;
            this.Password = password;
            this.Image = image;
            this.Cin = cin;
            this.Login = login;
            this.phonenumber = phone;
            this.Birthday = birth;
            this.roleadmin = role;
            this.isActive = isActive;
            this.daycare = daycare;
            this.healthRecords = healthRecords;
            this.availabilities = availabilities;

          
        }

        


    }
}