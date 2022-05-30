using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Razor.Hosting;

[assembly: RazorCompiledItem(typeof(HeaderFooter.Pages.PagesIndex), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]

namespace HeaderFooter.Pages;

[RazorCompiledItemMetadata("Identifier", "/Pages/Index.cshtml")]
public class PagesIndex : Page
{
    public override async Task ExecuteAsync()
    {
        // Auth forwarding can be anything here
        // comparable with a reverse proxy
        // TODO use streams
        var path = HttpContext.Request.Path;
        var responseMessage = await HttpClient.GetAsync("http://localhost:5100" + path);
        WriteLiteral(await responseMessage.Content.ReadAsStringAsync());
    }

    [RazorInject]
    public HttpClient HttpClient { get; private set; } = default!;

    public object Model { get; set; }
}
