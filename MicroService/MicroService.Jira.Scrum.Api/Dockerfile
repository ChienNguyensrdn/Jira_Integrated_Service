#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MicroService.Jira.Scrum.Api/MicroService.Jira.Scrum.Api.csproj", "MicroService.Jira.Scrum.Api/"]
RUN dotnet restore "MicroService.Jira.Scrum.Api/MicroService.Jira.Scrum.Api.csproj"
COPY . .
WORKDIR "/src/MicroService.Jira.Scrum.Api"
RUN dotnet build "MicroService.Jira.Scrum.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MicroService.Jira.Scrum.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MicroService.Jira.Scrum.Api.dll"]