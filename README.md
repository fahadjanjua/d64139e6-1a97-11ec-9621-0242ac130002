# Longest Increasing Subsequence

### Summary
ASP NET Core 5 API using docker-compose to run integration tests. 
The API finds longest increasing subsequence from a string input that contains whitespace separated integer values.

### Projects Overview
#### UI - Blazor Server App and has a single component to take the input via a text box and calls the API to find the longest increasing subsequence.
#### Api - [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0) API that finds the longest increasing subsequence from a series of whitespace separated integer values.
#### Tests - [xUnit](https://xunit.net/) is used as the testing framework.
#### [Docker](https://hub.docker.com/_/microsoft-dotnet-core) is used to run integration tests.
### Running the projects

#### Blazor Server UI App
Blazor Server UI app can be run via Visual Studio using the IIS Express.
To be able to test the API from the Blazor app, run the following command from the CLI to run the API in a docker container

```
  cd LIS

  docker-compose -f docker-compose.yml up
```

#### .NET API
.NET API can be run via Visual Studio using IIS Express and then can be tested using Postman.
The API can also be run inside a docker container by running following commands and tested with Postman or Blazor UI app

```
  cd LIS

  docker-compose -f docker-compose.yml up
```
# Running tests
#### In a docker container via `docker-compose`
To run the integration tests run the following commands from the CLI which will spin two docker containers one for the API and the other for the Tests project and the integration tests will be executed.
```
  cd LIS

  docker-compose -f docker-compose-tests.yml up
  OR
  docker-compose -f docker-compose-tests.yml run tests
```
# Continuous Integration
The solution has a CI pipeline via GitHub actions and runs tests whenever changes are committed or pushed to the master branch.
