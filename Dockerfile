  
  
  FROM mcr.microsoft.com/dotnet/aspnet:6.0
  ARG output
  COPY ${output} App/
  WORKDIR /App
  ENTRYPOINT ["dotnet", "BookAPI.dll"]