using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Http;

namespace 영상뷰어.Services
{
    public class SateliteJSONParsingService
    {
        public SateliteJSONParsingService(string json)
        {
            JObject jo = JObject.Parse(json);

            var imageList = ImageFileList(jo);

            foreach (var item in imageList)
            {
                string pattern = @"(\d{12})";
                Match match = Regex.Match(item, pattern);
                if(match.Success)
                {
                    string result = match.Value;
                    Console.WriteLine(result);
                }
                DownloadRemoteImageFile(item);
                Console.WriteLine($"item : {item}");
            }
        }
        private string[] ImageFileList(JObject jobject)
        {
            var body = jobject["response"]["body"];
            var items = body["items"]["item"];
            var imageitem = items.ToString().Replace("\r\n",string.Empty);
            imageitem= imageitem.Replace("[  {    \"satImgC-file\": \"[",string.Empty);
            var imageitems = imageitem.Split(',');

            return imageitems;
        }
        private async Task DownloadRemoteImageFile(string imageUrl)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(HttpMethod.Get, imageUrl))
                {
                    using (
                        StreamContent content = new StreamContent(await (await httpClient.SendAsync(request)).Content.ReadAsStreamAsync()))
                    {
                        var fileBytes = await content.ReadAsByteArrayAsync();
                        // Save the image file on the system
                        File.WriteAllBytes($"{Guid.NewGuid()}.jpg", fileBytes);
                    }
                }
            }
        }
    }
}