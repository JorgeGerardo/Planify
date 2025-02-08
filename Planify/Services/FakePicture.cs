using Newtonsoft.Json;
using Planify.Models;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Threading.Tasks;

namespace Planify.Services
{
    public static class FakePicture
    {
        private static string UrlApi = @"https://randomuser.me/sapi";
        public static async Task<string?> GetFakePictureUrl(Gender gender)
        {
            using (var http = new HttpClient())
            {
                string UrlRequest = UrlApi + setGenderParametter(gender);

                http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = await http.GetAsync(UrlRequest);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    RandomPicture? result = JsonConvert.DeserializeObject<RandomPicture>(responseContent);
                    return result?.results[0].picture.large;
                }
                else return null;
            }
        }

        private static string setGenderParametter(Gender gender)
        {
            string UrlParrams = "/?gender=";
            if (gender == Gender.Male) return UrlParrams += "male";
            else return UrlParrams += "female";
        }

    }
}
