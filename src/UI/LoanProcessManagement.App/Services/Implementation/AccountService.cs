﻿using LoanProcessManagement.App.Helper.APIHelper;
using LoanProcessManagement.App.Services.Interfaces;
using LoanProcessManagement.Application.Features.ChangePassword.Commands.ChangePassword;
using LoanProcessManagement.Application.Responses;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LoanProcessManagement.App.Services.Implementation
{
    public class AccountService : IAccountService
    {
        private string BaseUrl = "";
        private HttpClient _client;
        IOptions<APIConfiguration> _apiDetails;

        public AccountService(HttpClient client, IOptions<APIConfiguration> apiDetails)
        {
            _client = client;
            _apiDetails = apiDetails;
        }

        public async Task<Response<ChangePasswordDto>> ChangePassword(ChangePasswordCommand changePassword)
        {
            BaseUrl = _apiDetails.Value.LoanProcessAPIUrl;

            var model = new Response<ChangePasswordDto>();

            var content = JsonConvert.SerializeObject(changePassword);

            var httpResponse = await _client.PostAsync(BaseUrl + APIEndpoints.ChangePassword, new StringContent(content, Encoding.Default,
                "application/json"));

            var jsonString = httpResponse.Content.ReadAsStringAsync().Result;


            var options = new JsonSerializerOptions();
            model = System.Text.Json.JsonSerializer.Deserialize<Response<ChangePasswordDto>>(jsonString, options);

            //JavaScriptSerializer js = new JavaScriptSerializer();
            //getStatusResponseModel = js.Deserialize<EMandateGetStatusResponseModel>(Finalresult);
            //model = JsonSerializer.Deserialize<ChangePasswordDto>(jsonString);
            //model = jsonString.DeserializeJsonObject<ChangePasswordDto>();

            return model;
        }
    }
}
