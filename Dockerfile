FROM microsoft/dotnet:2.2-aspnetcore-runtime-nanoserver-1803 AS base
COPY WebApi/publish .
ENTRYPOINT ["dotnet", "WebApi.dll"]