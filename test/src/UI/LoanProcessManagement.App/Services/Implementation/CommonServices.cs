﻿using LoanProcessManagement.App.Helper.APIHelper;
using LoanProcessManagement.App.Services.Interfaces;
using LoanProcessManagement.Application.Features.Branch.Queries;
using LoanProcessManagement.Application.Features.LeadStatus.Queries;
using LoanProcessManagement.Application.Features.Product.Queries;
using LoanProcessManagement.Application.Features.Roles.Queries;
using LoanProcessManagement.Application.Responses;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace LoanProcessManagement.App.Services.Implementation
{
    public class CommonServices : ICommonServices
    {
        private string BaseUrl = "";
        private IHttpClientFactory clientfact;
        IOptions<APIConfiguration> _apiDetails;

        public CommonServices(IHttpClientFactory client, IOptions<APIConfiguration> apiDetails)
        {
            clientfact = client;
            _apiDetails = apiDetails;
        }

        #region This action method will internally call get all roles api by - Akshay Pawar 31/10/2021
        /// <summary>
        /// 31/10/2021 - This action method will internally call get all roles api 
        //	commented by Akshay
        /// </summary>
        /// <returns>response from api</returns>
        public async Task<IEnumerable<GetAllRolesDto>> GetAllRoles()
        {
            BaseUrl = _apiDetails.Value.LoanProcessAPIUrl;

            var _client = clientfact.CreateClient("LoanService");

            var httpResponse = await _client.GetAsync
                (
                    BaseUrl + APIEndpoints.GetRoles
                );

            var jsonString = httpResponse.Content.ReadAsStringAsync().Result;

            var options = new JsonSerializerOptions();

            var response = System.Text.Json.JsonSerializer.Deserialize<IEnumerable<GetAllRolesDto>>(jsonString, options);

            return response;
        }
        #endregion

        #region This action method will internally call get all branches api by - Akshay Pawar 31/10/2021
        /// <summary>
        /// 31/10/2021 - This action method will internally call get all branches api 
        //	commented by Akshay
        /// </summary>
        /// <returns>response from api</returns>
        public async Task<IEnumerable<GetAllBranchesDto>> GetAllBranches()
        {
            BaseUrl = _apiDetails.Value.LoanProcessAPIUrl;

            var _client = clientfact.CreateClient("LoanService");

            var httpResponse = await _client.GetAsync
                (
                    BaseUrl + APIEndpoints.GetBranches
                );

            var jsonString = httpResponse.Content.ReadAsStringAsync().Result;

            var options = new JsonSerializerOptions();

            var response = System.Text.Json.JsonSerializer.Deserialize<IEnumerable<GetAllBranchesDto>>(jsonString, options);

            return response;
        }
        #endregion

        #region This method will call get status api by - Akshay Pawar - 18/11/2021
        /// <summary>
        /// 18/11/2021 - This method will call get status api
        //	commented by Akshay
        /// </summary>
        /// <param name="role">role</param>
        /// <returns>response</returns>
        public async Task<Response<IEnumerable<GetLeadStatusDto>>> GetAllStatus(string role)
        {
            BaseUrl = _apiDetails.Value.LoanProcessAPIUrl;

            var _client = clientfact.CreateClient("LoanService");

            var httpResponse = await _client.GetAsync
                (
                    BaseUrl + APIEndpoints.GetStatus + role
                );

            var jsonString = httpResponse.Content.ReadAsStringAsync().Result;

            var options = new JsonSerializerOptions();

            var response = System.Text.Json.JsonSerializer.Deserialize<Response<IEnumerable<GetLeadStatusDto>>>(jsonString, options);

            return response;
        }

        #endregion
        #region This method will call get loan products api by - Akshay Pawar - 18/11/2021
        /// <summary>
        /// 18/11/2021 - This method will call get loan products api
        //	commented by Akshay
        /// </summary>
        /// <returns>response</returns>

        public async Task<Response<IEnumerable<GetLoanProductsDto>>> GetAllLoanProduct()
        {
            BaseUrl = _apiDetails.Value.LoanProcessAPIUrl;

            var _client = clientfact.CreateClient("LoanService");

            var httpResponse = await _client.GetAsync
                (
                    BaseUrl + APIEndpoints.GetLoanProducts
                );

            var jsonString = httpResponse.Content.ReadAsStringAsync().Result;

            var options = new JsonSerializerOptions();

            var response = System.Text.Json.JsonSerializer.Deserialize<Response<IEnumerable<GetLoanProductsDto>>>(jsonString, options);

            return response;
        } 
        #endregion

        #region This method will call get insurance products api by - Akshay Pawar - 18/11/2021
        /// <summary>
        /// 18/11/2021 - This method will call get insurance products api
        //	commented by Akshay
        /// </summary>
        /// <returns>response</returns>
        public async Task<Response<IEnumerable<GetInsuranceProductsDto>>> GetAllInsuranceProducts()
        {
            BaseUrl = _apiDetails.Value.LoanProcessAPIUrl;

            var _client = clientfact.CreateClient("LoanService");

            var httpResponse = await _client.GetAsync
                (
                    BaseUrl + APIEndpoints.GetInsuranceProducts
                );

            var jsonString = httpResponse.Content.ReadAsStringAsync().Result;

            var options = new JsonSerializerOptions();

            var response = System.Text.Json.JsonSerializer.Deserialize<Response<IEnumerable<GetInsuranceProductsDto>>>(jsonString, options);

            return response;
        } 
        #endregion
    }
}