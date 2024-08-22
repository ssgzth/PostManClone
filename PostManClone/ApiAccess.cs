

using System.Net;
using System.Text.Json;

namespace PostManCloneLibrary;
    public  class ApiAccess
{ 
        private readonly HttpClient _httpClient = new();
        public HttpStatusCode statusCode;


        public async Task<string> CallApi(string url)
        {   
            var response = await _httpClient.GetAsync(url);
            statusCode = response.StatusCode;
        if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                var jsonElement = JsonSerializer.Deserialize<JsonElement>(json);
                string prettyJson = JsonSerializer.Serialize(jsonElement, new JsonSerializerOptions { WriteIndented = true});
            return prettyJson;
            }
            else
            {          
             return $"Error : {response.StatusCode}";
        }
        
        }

        public string GetStatusCode() { 
             
        string s = statusCode.ToString();
        return s;
    
    }
     

     
    public bool IsValidUrl (string url)
    {
        if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
        {
            return true;
        }
        else return false;
    }

}

