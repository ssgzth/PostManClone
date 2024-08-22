

namespace PostManCloneLibrary
{
    public  class ApiAccess
{ 
        private readonly HttpClient _httpClient = new();
        public async Task<string> CallApi(string url)
        {
            var response = await _httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                return json;
            }
            else
            {
                return $"Error : {response.StatusCode}";
            }
        }

}
}
