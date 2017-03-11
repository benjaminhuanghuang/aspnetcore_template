# Add migration
$ dotnet ef migrations add Initial 
This command use the tools added in .csproj file
<ItemGroup>
    <DotNetCliToolReference Include="Microsoft.EntityFrameworkCore.Tools.DotNet" Version="1.0.0" />
</ItemGroup>


## Apply the migration
$ dotnet ef database update