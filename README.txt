Startup.cs file is a replacement of Global.asax file in ASP.NET Web Form application. We know that Global.asax is an optional file to handle Application level event in ASP.NET application. In ASP.NET 5, Startup.cs file has introduce to server same.

Though the purpose is the same, the implementation of Startup.cs file is entirely different. Global.asax file contains mostly application level pre-defined events where Startup.cs file is more about registering services and injection of modules in HTTP pipeline. Startup.cs file contains Startup class which triggers at first when application launches and even in each HTTP request/response.

Actually, the inception of Startup class is in OWIN application which is a specification to reduce dependency of application on server.

Startup class is allowed to put in any namespace, but the class name must not change. In runtime, it looks for Startup keyword in metadata.

Now the question may come, is startup class mandatory in application? Yes, startup class is mandatory in each ASP.NET 5 application. It can be decorated with any access specifier. Multiple Startup classes are allowed in a single application. ASP.NET will select the appropriate class based on its namespace. Here is rule to select.

At first, it matches with project’s root namespace first, otherwise using the class in the alphabetically first namespace.

Here is an example of a typical startup class which will scaffold once you choose empty ASP.NET5 template.



