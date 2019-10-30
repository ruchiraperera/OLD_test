swagger - sawashbuckle.core


just static file load - app.UseStaticFiles(); 
defualt index.html file load - app.UseDefaultFiles(); 
for general error page - app.UseExceptionHandler("/Error");

development exception show for request - app.UseDeveloperExceptionPage(); 

windows authentication - app.UseIISPlatformHandler();

XSRF/CSRF and Razor Pages - You don't have to write any code for antiforgery validation. 
Antiforgery token generation and validation areautomatically included in Razor Pages.


directory browsing

public void Configure(IApplicationBuilder app)
{
    app.UseStaticFiles(); // For the wwwroot folder

    app.UseFileServer(new FileServerOptions
    {
        FileProvider = new PhysicalFileProvider(
            Path.Combine(Directory.GetCurrentDirectory(), "MyStaticFiles")),
        RequestPath = "/StaticFiles",
        EnableDirectoryBrowsing = true
    });
}

AddDirectoryBrowser must be called when the EnableDirectoryBrowsing property value is true:

services.AddDirectoryBrowser();

Using the file hierarchy and preceding code, URLs resolve as follows:
URI 	Response
http://<server_address>/StaticFiles/images/banner1.svg 	MyStaticFiles/images/banner1.svg
http://<server_address>/StaticFiles 	MyStaticFiles/default.html

setup MVC ----------------------------------------------------------------------------------------

make defualt route in MVC -  app.UseMvcWithDefaultRoute();

allow MVC service -  services.AddMvc();

Name 	Behavior
ContentResult -	Returns a string
FileContentResult -	Returns file content
FilePathResult -	Returns file content
FileStreamResult -	Returns file content.
EmptyResult -	Returns nothing
JavaScriptResult -	Returns script for execution
JsonResult -	Returns JSON formatted data
RedirectToResult -	Redirects to the specified URL
HttpUnauthorizedResult -	Returns 403 HTTP Status code
RedirectToRouteResult -	Redirect to different action/ different controller action
ViewResult -	Received as a response for view engine
PartialViewResult -	Received as a response for view engine
ObjectResult  - return json object


view html path structure

viewstart > layout > view

if we need we can add view import file - which will be used to add using directives in global place - @using FirstAppDemo.Controllers 

Tag helpers - enable server side code to render Html pages. 