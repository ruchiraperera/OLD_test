Go to NuGet Package Manager from Tools -> 
NuGet Package Manager-> Manage NuGet packages for solution - > 
and search for swashbuckle for ASP.NET Core.


Go to the startup.cs file and add the following code to the ConfigureService method.

    services.AddSwaggerGen(c=> { c.SwaggerDoc("v1", new Info { Title = "Employee API", Version = "V1" });  
                });   

The above code is used to add the swagger document generation to the service.
 
Add the following code in the Configure method.

    app.UseSwagger();  
                app.UseSwaggerUI(c=> {  
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "post API V1");  
                    });  

The above code is used to define the end points for the Swagger UI
 
Let’s run the application.
 
Switch to the Swagger UI (localhost:44336/swagger/index.html) . You can find the documentation of all your APIs as shown 
in the following picture.
