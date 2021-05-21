using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using AKSoftware.WebApi.Client;
using BlazorForGithub.Shared.Models;

namespace BlazorForGithub.Shared.Services
{
    public class AuthenticationService
    {
        private readonly string _baseUrl;

        private ServiceClient client = new();

        public AuthenticationService(string url)
        {
            _baseUrl = url;
        }


        public async Task<UserManagerResponse> RegisterUserAsync(RegisterRequest request)
        {
            var response = await client.PostAsync<UserManagerResponse>($"{_baseUrl}/api/BlazorForGithub/auth/register", request);

            return response.Result;
        }

        public async Task<UserManagerResponse> LoginUserAsync(LoginRequest request)
        {
            var response = await client.PostAsync<UserManagerResponse>($"{_baseUrl}/api/BlazorForGithub/auth/login", request);

            return response.Result;
        }
    }
}
