# ASP.NET Core 

## Update
    January 2017 Update for ASP.NET Core 1.1
        Run $ dotnet migrate to convert project.json to .csproj

## Support static file
    Modify Startup.cs->Configure()
        app.UseStaticFiles();


## Cross-Origin Requests
    Using CORS(Cross Origin Resource Sharing), a server can explicitly allow some cross-origin requests. 
    
    Add reference in .csproj : 
        <PackageReference Include="Microsoft.AspNetCore.Cors" Version="1.1.0" />
    Modify Startup.cs->Configure()
        app.UseCors(builder =>builder.WithOrigins("http://localhost:9000").AllowAnyHeader().AllowAnyMethod());
