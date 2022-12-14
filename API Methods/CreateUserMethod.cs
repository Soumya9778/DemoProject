using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITest_Dec2022.API_Mappings
{
    public class CreateUserMethod
    {
        string payload = @"{
                            ""name"": ""Raj"",
                             ""job"": ""leader""
                            }";
        public CreateUser UserCreation()
        {
            var restClient = new RestClient("https://reqres.in/");
            var restRequest = new RestRequest("/api/users", Method.Post);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddBody(payload);
            restRequest.RequestFormat = DataFormat.Json;
            RestResponse response = restClient.Execute(restRequest);
            var content = response.Content;

            var users = JsonConvert.DeserializeObject<CreateUser>(content);
            return users;
        }
    }
}
