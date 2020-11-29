#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["BMS.ApiGateway/BMS.ApiGateway.csproj", "BMS.ApiGateway/"]
RUN dotnet restore "BMS.ApiGateway/BMS.ApiGateway.csproj"
COPY . .
WORKDIR "/src/BMS.ApiGateway"
RUN dotnet build "BMS.ApiGateway.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BMS.ApiGateway.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BMS.ApiGateway.dll"]