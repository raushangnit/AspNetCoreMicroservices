#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Solution Items/APIGateways/OcelotAPIGateway/OcelotAPIGateway.csproj", "Solution Items/APIGateways/OcelotAPIGateway/"]
COPY ["Solution Items/BuildingBlocks/Common.Logging/Common.Logging.csproj", "Solution Items/BuildingBlocks/Common.Logging/"]
RUN dotnet restore "Solution Items/APIGateways/OcelotAPIGateway/OcelotAPIGateway.csproj"
COPY . .
WORKDIR "/src/Solution Items/APIGateways/OcelotAPIGateway"
RUN dotnet build "OcelotAPIGateway.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OcelotAPIGateway.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OcelotAPIGateway.dll"]