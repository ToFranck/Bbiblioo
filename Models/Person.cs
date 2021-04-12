using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bbiblioo.Models
{
    public class Person
    {

        private Int32 person_id;
        private String civility;
        private String last_name; 
        private String first_name;
        private DateTime birthday;
        private String publishing_house;
        private String email;
        private String phone_number;
        private String address_1;
        private String adress_2;
        private String zip_code;
        private String city;
        private String country;
        private String password;
        private String validated_charter; 
        private String validated_charter_date;
        private DateTime person_update_date; 


        public Int32 Person_id
        {
            get { return this.person_id; }
            set { this.person_id = value;  }
        }
        
        public String Civility
        {
            get { return this.civility; }
            set { this.civility = value; }
        }

        public String Last_name
        {
            get { return this.last_name; }
        }
        public String First_name { get; set; }

        public DateTime Birthday { get; set; }

        public String Publishshing_house { get; set; } 

        public String Email { get; set; }

        public String Phone_number { get; set; }

        public String Adress_1 { get; set; }    

        public String Adress_2 { get; set; }

        public String Zip_code { get; set; }    
        
        public String City { get; set; }

        public String Country { get; set; } 

        public String Password { get; set; }

        public String Validated_charter { get; set; }

        public String Validated_charter_date { get; set; }

        public DateTime Person_update_date { get; set; }

        public void create_person()
        {

        }

        public void update_person()
        {
                        
        }

        public void verif_person()
        {

        }

        public void delete_person() 
        { 

        }

        public void fonction_id()
        {

        }


    }

        
}
