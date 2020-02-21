#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-nanoserver-1803 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-nanoserver-1803 AS build
WORKDIR /src
COPY ["startup_file_configuration/startup_file_configuration.csproj", "startup_file_configuration/"]
RUN dotnet restore "startup_file_configuration/startup_file_configuration.csproj"
COPY . .
WORKDIR "/src/startup_file_configuration"
RUN dotnet build "startup_file_configuration.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "startup_file_configuration.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "startup_file_configuration.dll"]