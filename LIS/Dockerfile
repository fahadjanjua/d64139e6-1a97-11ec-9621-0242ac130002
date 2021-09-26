FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim as builder
COPY . /code
WORKDIR /code/Api
RUN dotnet restore && dotnet publish -c Release -o publish

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim
COPY --from=builder /code/Api/publish /app
WORKDIR /app
ENV ASPNETCORE_URLS="http://*:5000"
EXPOSE 5000
ENTRYPOINT [ "dotnet", "/app/Api.dll" ]