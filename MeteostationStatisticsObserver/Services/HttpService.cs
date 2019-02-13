using MeteostationStatisticsObserver.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MeteostationStatisticsObserver
{
    public class HttpService
    {
        public static HttpClient client { get; } = new HttpClient()
        {
            BaseAddress = new Uri(Constants.DomainAddress)
        };


        public async Task<UserInfo[]> GetUserInfo()
        {
            var res = await client.GetAsync(Constants.ApiGetUsers);
            var users = JsonConvert.DeserializeObject<UserInfo[]>(await res.Content.ReadAsStringAsync());
            return users;
        }

        public async Task<List<StatisticsResult>> GetStatistics(string username, DateTime startTime, DateTime endTime, decimal sampleSize = 0.1M)
        {
            var qstring = System.Web.HttpUtility.ParseQueryString(String.Empty);
            qstring.Add(Constants.FormDataKetSampleSize, sampleSize.ToString());
            qstring.Add(Constants.FormDataKeyStartTime, startTime.ToString(Constants.ApiDateTimeFormat));
            qstring.Add(Constants.FormDataKeyEndTime, endTime.ToString(Constants.ApiDateTimeFormat));
            qstring.Add(Constants.FormDataKeyUserName, username);

            var url = $"{Constants.ApiGetStats}?{qstring}";

            var res = await client.GetAsync(url);
            var values = JsonConvert.DeserializeObject<List<StatisticsResult>>(await res.Content.ReadAsStringAsync());
            return values;
        }
    }

    public class StatisticsResult
    {
        public string Temperature { get; set; }
        public string Humidity { get; set; }
        public DateTime MeasurementTime { get; set; }
    }
}
