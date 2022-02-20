FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine as build
WORKDIR /app
COPY . .
RUN dotnet restore MasterSolution.sln
RUN dotnet publish MasterSolution.sln -o /app/published-app

FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine as runtime
WORKDIR /app
COPY --from=build  /app/published-app /app
ENTRYPOINT [ "dotnet", "/app/aspnet_core_demo.dll" ]