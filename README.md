ASP.NET Core Project Template
=====================================
# How to Run
    $ dotnet restore      # restore packages
    $ dotnet build
    $ dotnet run

## Hello Word Project Structure
/Project
    /wwwroot
        /css
        /images
        /js
        favicon.ico
    Startup.cs
    Program.cs           # Entry of asp.net core application
    web.config
    project.json         # dotnet build need this file, .NET core 1.1 donot support project.json
    package.json
    bower.json
    appsettings.json

### A mapping between project.json and csproj properties
    
    https://docs.microsoft.com/en-us/dotnet/articles/core/tools/project-json-to-csproj
    run dotnet migrate to covert project.json to csproj 

## Common Project Structure
/Project
    /Models
        /AAAViewModels
        /BBBViewModels
    /Views
        /Home
        /Manage
        /Account
        /Shared
            _Layout.cshtml
            Error.cshtml
            _LoginPartial.cshtml
        _ViewImports.cshtml
        _ViewStart.cshtml
    /Coltrollers
    /Services
    /Data
        /Migrations
        ApplicationDbContext.cs
    /wwwroot
        /css
        /images
        /js
        favicon.ico
    Startup.cs
    Program.cs
    web.config
    package.json
    bower.json
    appsettings.json




## This application consists of:

## How to


## Overview

