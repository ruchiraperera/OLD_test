
 HTTPHandlers are used by ASP.NET to handle the specific requests based on extensions. HTTPModule, on the other hand, 
 is used if we want to have 
 our own functionality working along with the default ASP.NET functionality

 HttpHandler

HttpHandler are extension based. They used to handle requests for file name with specific extension, such as .rss. 
The most common handler is an ASP.NET page handler that processes .aspx files. When users request an .aspx file, 
the request is processed by the page through the page handler. You can configure them in web.config.

HttpModule

HttpModules are event based. It is called on every request that is made to your application. HTTP modules 
are called as part of the ASP.NET request pipeline and have access to life-cycle events throughout the request. 
And they are also configured via web.config or Global.asax.

//-------------------------------------------------------------------------------------------------------------------

 HttpHandler (example is a bad solution)

  HTTP Handler: Sometime we need to avoid ASP.NET full page processing model, which saves lot of overheads, as ASP.NET web form model 
  has to go through many steps such as creating web page objects, persisting view state etc. The HTTP handler is the most important 
  ingredient while handling ASP.NET requests.

  Examples:

    Dynamic image creator - Use the System.Drawing classes to draw and size your own images.
    RSS - Create a handler that responds with RSS-formatted XML. This would allow you to add RSS feed capabilities to your sites.
    Render a custom image,
    Perform an ad hoc database query,
    Return some binary data.

public class CspxHandler :IHttpHandler
{
    public bool IsReusable
    {
        get { return false; }
    }

    public void ProcessRequest(HttpContext context)
    {
		context.Response.ContentType = "text/plain";

        if (context.Request.RawUrl.Contains(".cspx"))
        {
            string newUrl = context.Request.RawUrl.Replace(".cspx", ".aspx");
            context.Server.Transfer(newUrl);
        }
    }
}

web config
<httpHandlers>
    <add verb="*" path="*.cspx" type="CspxHandler"/>
</httpHandlers>


HttpModule

What is HTTP module: Help in processing of page request by handing application events , similar to what global.asax does. 
A request can pass through many HTTP modules but is being handled by only one HTTP handlers.

public class MyBModule : IHttpModule
{
    public void Dispose()
    {

    }

    public void Init(HttpApplication context)
    {
        context.BeginRequest += new EventHandler(context_BeginRequest);
        context.PreRequestHandlerExecute += new EventHandler(context_PreRequestHandlerExecute);
        context.EndRequest += new EventHandler(context_EndRequest);
        context.AuthorizeRequest += new EventHandler(context_AuthorizeRequest);
    }

    void context_AuthorizeRequest(object sender, EventArgs e)
    {
        //We change uri for invoking correct handler
        HttpContext context = ((HttpApplication)sender).Context;

        if (context.Request.RawUrl.Contains(".bspx"))
        {
            string url = context.Request.RawUrl.Replace(".bspx", ".aspx");
            context.RewritePath(url);
        }
    }

    void context_PreRequestHandlerExecute(object sender, EventArgs e)
    {
        //We set back the original url on browser
        HttpContext context = ((HttpApplication)sender).Context;

        if (context.Items["originalUrl"] != null)
        {
            context.RewritePath((string)context.Items["originalUrl"]);
        }
    }

    void context_EndRequest(object sender, EventArgs e)
    {
        //We processed the request
    }

    void context_BeginRequest(object sender, EventArgs e)
    {
        //We received a request, so we save the original URL here
        HttpContext context = ((HttpApplication)sender).Context;

        if (context.Request.RawUrl.Contains(".bspx"))
        {
            context.Items["originalUrl"] = context.Request.RawUrl;
        }
    }
}

in web.config

<httpModules>
    <add name="MyBModule" type="MyBModule" />
</httpModules>