#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:5.0-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["LIS.Tests/LIS.Tests.csproj", "LIS.Tests/"]
COPY ["LIS.API/LIS.API.csproj", "LIS.API/"]
RUN dotnet restore "LIS.Tests/LIS.Tests.csproj"
COPY . .
WORKDIR "/src/LIS.Tests"
RUN dotnet build "LIS.Tests.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LIS.Tests.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LIS.Tests.dll"]