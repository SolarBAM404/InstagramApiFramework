using System.Net.Http.Headers;

namespace InstagramApiFramework;

/// <summary>
/// The GraphApi class is responsible for making HTTP requests to the Instagram Graph API.
/// </summary>
public class GraphApi
{
    private readonly string _baseUrl = "https://graph.instagram.com";

    /// <summary>
    /// Makes a GET request to the specified endpoint of the Instagram Graph API.
    /// </summary>
    /// <param name="endpoint">The endpoint to make the request to.</param>
    /// <param name="accessToken">The access token to use for authorization.</param>
    /// <returns>The response from the API as a string.</returns>
    public async Task<string> GetAsync(string endpoint, string accessToken)
    {
        using (HttpClient client = new HttpClient())
        {
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", accessToken);
            HttpResponseMessage response =
                await client.GetAsync($"{_baseUrl}/{endpoint}");
            return await response.Content.ReadAsStringAsync();
        }
    }

    /// <summary>
    /// Makes a POST request to the specified endpoint of the Instagram Graph API.
    /// </summary>
    /// <param name="endpoint">The endpoint to make the request to.</param>
    /// <param name="accessToken">The access token to use for authorization.</param>
    /// <param name="content">The content to send in the body of the request.</param>
    /// <returns>The response from the API as a string.</returns>
    public async Task<string> PostAsync(
        string endpoint,
        string accessToken,
        HttpContent content
    )
    {
        using (HttpClient client = new HttpClient())
        {
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", accessToken);
            HttpResponseMessage response =
                await client.PostAsync($"{_baseUrl}/{endpoint}",
                    content);
            return await response.Content.ReadAsStringAsync();
        }
    }

    /// <summary>
    /// Makes a DELETE request to the specified endpoint of the Instagram Graph API.
    /// </summary>
    /// <param name="endpoint">The endpoint to make the request to.</param>
    /// <param name="accessToken">The access token to use for authorization.</param>
    /// <returns>The response from the API as a string.</returns>
    public async Task<string> DeleteAsync(string endpoint,
        string accessToken
    )
    {
        using (HttpClient client = new HttpClient())
        {
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", accessToken);
            HttpResponseMessage response =
                await client.DeleteAsync($"{_baseUrl}/{endpoint}");
            return await response.Content.ReadAsStringAsync();
        }
    }

    /// <summary>
    /// Makes a PUT request to the specified endpoint of the Instagram Graph API.
    /// </summary>
    /// <param name="endpoint">The endpoint to make the request to.</param>
    /// <param name="accessToken">The access token to use for authorization.</param>
    /// <param name="content">The content to send in the body of the request.</param>
    /// <returns>The response from the API as a string.</returns>
    public async Task<string> PutAsync(string endpoint,
        string accessToken,
        HttpContent content
    )
    {
        using (HttpClient client = new HttpClient())
        {
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", accessToken);
            HttpResponseMessage response =
                await client.PutAsync($"{_baseUrl}/{endpoint}", content);
            return await response.Content.ReadAsStringAsync();
        }
    }
}