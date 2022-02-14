using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace HTMLParcer.Core
{
    class HTMLLoader
    {
        readonly HttpClient client;
        readonly string url;

        public HTMLLoader (IPSettings settings)
        {
            client = new HttpClient();
            url = $"{settings.url}/{settings.prefix}/";
        }

        public async Task<string> GetSourceByPageId(int id)
        {
            var currentUrl = url.Replace("{CurrentId}", id.ToString());
            var response = await client.GetAsync(currentUrl);
            string source = null;

            if (response != null && response.StatusCode == HttpStatusCode.OK)
            {
                source = await response.Content.ReadAsStringAsync();
            }

            return source;
        }
    }
}
