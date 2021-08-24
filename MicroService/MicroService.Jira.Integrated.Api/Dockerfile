#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MicroService.Jira.Integrated.Api/MicroService.Jira.Integrated.Api.csproj", "MicroService.Jira.Integrated.Api/"]
RUN dotnet restore "MicroService.Jira.Integrated.Api/MicroService.Jira.Integrated.Api.csproj"
COPY . .
WORKDIR "/src/MicroService.Jira.Integrated.Api"
RUN dotnet build "MicroService.Jira.Integrated.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MicroService.Jira.Integrated.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MicroService.Jira.Integrated.Api.dll"]