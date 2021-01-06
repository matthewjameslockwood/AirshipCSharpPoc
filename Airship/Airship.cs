using Airship.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Airship
{
    public class Airship
    {
        public System.Net.Http.Headers.AuthenticationHeaderValue authorizationHeader { get; set; }
        private string baseUrl = "https://go.urbanairship.com";

        public Airship(string applicationKey, string applicationSecretOrMasterSecret)
        {
            var textToEncode = $"{applicationKey}:{applicationSecretOrMasterSecret}";

            var plainTextBytes = Encoding.ASCII.GetBytes(textToEncode);
            var base64String = Convert.ToBase64String(plainTextBytes);

            authorizationHeader = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", base64String);
        }

        public async Task<string> PushNotification(string namedUser, Notification notification)
        {
            using (var client = new HttpClient())
            {

                var testObject = new PushObject()
                {
                    Audience = new Audience() { 
                        NamedUser = namedUser
                    },
                    Notification = notification,
                    DeviceTypes= new List<string>() { "web" }
                };

                var requestContent = JsonConvert.SerializeObject(testObject);

                var request = new HttpRequestMessage()
                {
                    RequestUri = new Uri($"{baseUrl}/api/push"),
                    Method = HttpMethod.Post,
                    Content = new StringContent(requestContent)
                };

                client.DefaultRequestHeaders.Authorization = authorizationHeader;

                var result = await client.SendAsync(request);

                return await result.Content.ReadAsStringAsync(); 
            }
        }

        // connect named user and channels:
        // https://docs.airship.com/api/ua/#operation/api/named_users/associate/post
        public async Task<string> PostChannel()
        {
            return await Task.Run(() => { Console.WriteLine(); return ""; });
        }

        public async Task<string> GetAllChannels()
        {
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage()
                {
                    RequestUri = new Uri($"{baseUrl}/api/channels/"),
                    Method = HttpMethod.Get
                };

                var result = await client.SendAsync(request);
            }

            return await Task.Run(() => { Console.WriteLine(); return ""; });
        }

        public async Task<string> GetChannel(string channelId)
        {
            return await Task.Run(() => { Console.WriteLine(); return ""; });
        }


    }
}
