FROM microsoft/dotnet:2.2-aspnetcore-runtime-nanoserver-1803 AS base
COPY WebApi/bin/Debug/netcoreapp2.2/publish/WebApi.dll .
ENTRYPOINT ["dotnet", "WebApi.dll"]