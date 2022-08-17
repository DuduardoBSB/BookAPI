  
  
  FROM mcr.microsoft.com/dotnet/aspnet:6.0
  ARG publish
  COPY publish App/
  WORKDIR /App
  ENTRYPOINT ["dotnet", "BookAPI.dll"]