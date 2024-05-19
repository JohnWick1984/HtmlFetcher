using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HtmlFetcherLib
{
    public class HtmlFetcher
    {
        public async Task<string> GetHtmlAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    return await response.Content.ReadAsStringAsync();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error fetching HTML", ex);
                }
            }
        }
    }
}
