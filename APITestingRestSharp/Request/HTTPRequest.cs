using NUnit.Framework;
using RestSharp;
using System;

namespace APITestingRestSharp
{
    public class HTTPRequest
    {

        String base_url = "http://localhost:3000/users";

        //Get all users information
        public IRestResponse GetAll()
        {
            var client = new RestClient(base_url);
            var request = new RestRequest(Method.GET);

            request.AddHeader("Postman-Token", "7340c134-3a9e-488c-b0f9-cd33098ff129");
            request.AddHeader("Cache-Control", "no-cache");
            IRestResponse response = client.Execute(request);

            return response;

        }

        //Get user information by id
        public IRestResponse GetById(String id)
        {
            var client = new RestClient(base_url + "/" + id);
            var request = new RestRequest(Method.GET);

            request.AddHeader("Postman-Token", "e90fe544-65d8-4855-980d-d7a3ac387f79");
            request.AddHeader("Cache-Control", "no-cache");
            IRestResponse response = client.Execute(request);

            return response;
        }

        //Create user 
        public IRestResponse Post(String post_data)
        {

            var client = new RestClient(base_url);
            var request = new RestRequest(Method.POST);

            request.AddHeader("Postman-Token", "234e5382-b3d5-45aa-b41c-25dad5fef057");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined",post_data,ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            return response;
        }

        //Update user information
        public IRestResponse PutById(String put_data,String id )
        {

            var client = new RestClient(base_url + "/" + id);
            var request = new RestRequest(Method.PUT);

            request.AddHeader("Postman-Token", "9d8088c0-da43-491c-922d-250e2bde2d74");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", put_data, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            return response;
        }

        //Delete user by id
        public IRestResponse DeleteById(String id)
        {
            var client = new RestClient(base_url + "/" + id);
            var request = new RestRequest(Method.DELETE);

            request.AddHeader("Postman-Token", "7c996e35-2be3-4f66-b9dc-4163bf53d278");
            request.AddHeader("Cache-Control", "no-cache");
            IRestResponse response = client.Execute(request);

            return response;
        }



      

    }
}
