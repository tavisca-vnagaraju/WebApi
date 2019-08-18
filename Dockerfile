FROM microsoft/dotnet:2.2-aspnetcore-runtime-nanoserver-1803 AS base
ARG APP_NAME"Default"
COPY ./publish .
ENTRYPOINT ["dotnet", "${APP_NAME}.dll"]
