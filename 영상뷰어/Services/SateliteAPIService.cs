using System.Net;
using System.Net.Http;
using System.IO;
using System;
using System.Threading.Tasks;

public class SateliteAPIService
{
    HttpClient client = new HttpClient();
    string? url;
    public SateliteAPIService()
    {
        string date = DateTime.Now.AddDays(-1).ToString("yyyyMMdd");
        url = "http://apis.data.go.kr/1360000/SatlitImgInfoService/getInsightSatlit"; // URL
        url += "?ServiceKey=" + "miUyD1M5iEJ3dMifSVNYib0E9mHEKcRQIj6v2XngOxBM9z%2FVXirTPMmTVLPqZITUCn%2Fl5KGPfsTf29ArnsoSxA%3D%3D"; // Service Key
        url += "&pageNo=1";
        url += "&numOfRows=10";
        url += "&dataType=JSON";
        url += "&sat=G2";
        url += "&data=ir105";
        url += "&area=ko";
        url += $"&time={date}";
    }
    public async Task<string> ResponseAPI()
    {
        try
        {
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine("\nException Caught!");
            Console.WriteLine("Message :{0} ", e.Message);
            return null;
        }
    }
}