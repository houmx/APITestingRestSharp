using System;

namespace APITestingRestSharp
{
     public class Users
    {
        public string id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string phone { get; set; }

        public Users(string firstname, string lastname, string phone){

            this.firstname = firstname;
            this.lastname = lastname;
            this.phone = phone;
            
        }
    }
}