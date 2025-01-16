FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
WORKDIR /app
COPY publish/ .
EXPOSE 5275
ENTRYPOINT ["dotnet", "HelloWorld-api.dll"]
