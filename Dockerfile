FROM microsoft/dotnet:2.2-aspnetcore-runtime-nanoserver-1803 AS base
ARG app_name="Default"
COPY ./publish .
ENTRYPOINT ["dotnet", "${app_name}.dll"]