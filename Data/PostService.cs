using RestSharp;
using System;
using System.Text.Json;

namespace StudyPortalMAUI.Data;

public class PostsService
{
	public Post GetPost()
    {
        var client = new RestClient("http://localhost:8000/api");
        var request = new RestRequest("posts", Method.Get);
        request.AddHeader("Authorization", "Bearer PVeeYv3iVjD97Vnn7A94yHkjeOwCIywiV8e6DfXF");

        var response = client.Execute(request);
        
        var list = JsonSerializer.Deserialize<Post>(response.Content);

        return list;

        /*return Task.FromResult(list => new Post[] { list });*/
    }
}
