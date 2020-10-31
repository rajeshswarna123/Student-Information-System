using Blazored.LocalStorage;
using Newtonsoft.Json;
using SIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace SIS.Client.Pages
{
    public partial class Login
    {
        private readonly LoginRequest model = new LoginRequest();

        public bool ShowErrors { get; set; }

        public IEnumerable<string> Errors { get; set; }
        private async Task SubmitAsync()
        {
            var request = new HttpRequestMessage(HttpMethod.Post, "https://localhost:44340/api/security/signin");

            //request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJVc2VySWQiOiIxIiwiU2Vzc2lvbklkIjoiNDU3MTdjYmEtOTM0OS00MjcyLWE1OTEtNTk3MTdkMzkwZWI2IiwibmJmIjoxNjA0MTUwNDczLCJleHAiOjE2MDQxNTc2NzMsImlhdCI6MTYwNDE1MDQ3MywiaXNzIjoiU3R1ZGVudEluZm9ybWF0aW9uU3lzdGVtV2ViQXBpIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTQ1MjQvIn0.3StYj88ai8voYh09fkoN4bTvEgWEoqwz79uL0W6LG4s");
            var httpClient = new HttpClient();

            var response = await httpClient.PostAsJsonAsync("https://localhost:44340/api/security/signin", model);
            Console.WriteLine(response.Content.ReadAsStringAsync());

            var user = JsonConvert.DeserializeObject<UserProfile>(await response.Content.ReadAsStringAsync());
            // send request
            //using var httpResponse = await httpClient.SendAsync(request);

            // convert http response data to UsersResponse object
            //var response = await httpResponse.Content.ReadAsStringAsync();
            //JsonConvert.DeserializeObject<UserProfile>(response);
            //Console.WriteLine(response);

            //var result = await this.AuthService.Login(this.model);

            //if (result.Succeeded)
            //{
            //    this.ShowErrors = false;
            //}
            //else
            //{
            //    this.Errors = result.Errors;
            //    this.ShowErrors = true;
            //}
        }
    }
}
