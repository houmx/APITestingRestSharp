using NUnit.Framework;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace APITestingRestSharp
{
    class APITestCase
    {
        HTTPRequest request = new HTTPRequest();

        //Check Post Request
        [Test]
        public void TC1()
        {
     
            Users data = new Users("hmx", "hou", "021888888");
            string post_data = JsonConvert.SerializeObject(data);
            var response = request.Post(post_data);
            Console.Error.Write(response.Content);

            //convert json to object
            Users actual = JsonConvert.DeserializeObject<Users>(response.Content);

            Assert.True(actual.firstname.Equals(data.firstname) & actual.lastname.Equals(data.lastname) & actual.phone.Equals(data.phone));
        }

        //Check PUT Request
        [Test]
        public void TC2()
        {
            var getAllResponse = request.GetAll();
            List<Users> user = JsonConvert.DeserializeObject<List<Users>>(getAllResponse.Content);
  
            Users data = new Users("hmx-new11", "hou-new", "292929299");
            string put_data = JsonConvert.SerializeObject(data);
            var PutByIdresponse = request.PutById(put_data, user[0].id);
            Users actual = JsonConvert.DeserializeObject<Users>(PutByIdresponse.Content);

            Assert.True(actual.firstname.Equals(data.firstname) & actual.lastname.Equals(data.lastname) & actual.phone.Equals(data.phone));
        }

        //Check Delete Request
        [Test]
        public void TC3()
        {
            var getAllResponse = request.GetAll();
            List<Users> user = JsonConvert.DeserializeObject<List<Users>>(getAllResponse.Content);

            var DeleteByIdresponse = request.DeleteById(user[0].id);
            string expect = user[0].id + " Delete succesfully!";
            string actual = DeleteByIdresponse.Content;
            Console.Error.Write(actual);
            Assert.True(actual.Equals(expect));
        }
    }
}
