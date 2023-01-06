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
        private string[] parsingJsonData;
        public SateliteJSONParsingService(string json)
        {
            JObject jo = JObject.Parse(json);
            parsingJsonData = ImageFileList(jo);           
        }
        public async Task<List<string>> DownLoadIMage()
        {
            List<string> resultFileNameList;

            foreach (var item in parsingJsonData)
            {
                string result;
                string pattern = @"(?:rgb-daynight_|ir|rgb-true_|wv|vi|sw)(\w+_\w+_\d+)";
                Match match = Regex.Match(item, pattern);
                
                if(match.Success)                
                    result = match.Value;                                    
                var fileName = awit DownloadRemoteImageFile(item, rsult);
                resultFileNameList.Add(fileName);
                Console.WriteLine($"item : {item}");
            }
            return resultFileNameList;
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
        private async Task<string> DownloadRemoteImageFile(string imageUrl, string fileName)
        {
            string filePath;
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(HttpMethod.Get, imageUrl))
                {
                    using (
                        StreamContent content = new StreamContent(await (await httpClient.SendAsync(request)).Content.ReadAsStreamAsync()))
                    {
                        var fileBytes = await content.ReadAsByteArrayAsync();
                        // Save the image file on the system
                        File.WriteAllBytes($"{fileName}.jpg", fileBytes);
                        filePath = $@"{System.IO.Directory.GetCurrentDirectory()}/{fileName}";                        
                    }
                    return filePath;
                }
            }
        }
    }
}