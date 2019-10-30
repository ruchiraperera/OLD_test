[ValidateInput(false)] // model state validation remove

Fighting with xss

01. html encoding => this automatically done with mvc .net
02. regular expression => adding validation


//------------------------------------------------------------------

03. anti xss library => ASP.NET Avoiding Cross-Site Scripting

this can be done with [allowhtml] attribute.
public class MyModel
{
    [AllowHtml]
    public string HtmlContent { get; set; }
}

//------------------------------------------------------------------

04. Request validation - encoding is the solution

*important = > store encoded html in database

//-----------------------------------------------

preventing CSRF (cross site request forgery) - OWASP.org check cheat sheet

01. header validation
02. synchronizer token pattern
03. Double submit token


ASP.net core Antiforgery  Asp.net core antiforgery package need to add
[validateAntiForgeryToken]

with html.brginform it auto apply the requestvarificationtoken field to form. therefore we can apply
[validateAtiForgeryToken] attribute to the method or else can add a auto validation rule to startup.cs

//specify options for the anti forgery here
services.AddAntiforgery();
//anti forgery as global filter
//services.AddMvc(options => options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute()));
then if you dont want antiforgery validation [ingoreAntiForgeryToken]


[AcceptVerbs]



