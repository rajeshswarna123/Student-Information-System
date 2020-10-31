//using System.Net.Http;
//using System.Net.Http.Headers;
//using System.Threading.Tasks;

//namespace SIS.Client
//{
//    public static class ServiceExtensions
//    {
//        public static async Task<T> GetJsonAsync<T>(this HttpClient httpClient, string url, AuthenticationHeaderValue authorization)
//        {
//            var request = new HttpRequestMessage(HttpMethod.Get, url);
//            request.Headers.Authorization = authorization;

//            var response = await httpClient.SendAsync(request);
//            var responseBytes = await response.Content.ReadAsByteArrayAsync();
//            return JsonSerializer.Parse<T>(responseBytes, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
//        }
//    }
//}
