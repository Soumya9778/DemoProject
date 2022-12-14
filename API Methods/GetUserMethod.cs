using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITest_Dec2022.API_Methods
{
    public class GetUserMethod
    {
        public GetListOfUsers GetUserList()
        {
            var restClient = new RestClient("https://reqres.in/");
            var restRequest = new RestRequest("/api/users?page=2", Method.Get);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.RequestFormat = DataFormat.Json;
            RestResponse response = restClient.Execute(restRequest);
            var content = response.Content;

            var users = JsonConvert.DeserializeObject<GetListOfUsers>(content);
            return users;

        }
    }
    
}
