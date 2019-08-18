FROM microsoft/dotnet:2.2-aspnetcore-runtime-nanoserver-1803 AS base
ARG dll_name="Default"
RUN echo ${dll_name}
COPY ./publish .
ENTRYPOINT ["dotnet", "${dll_name}.dll"]