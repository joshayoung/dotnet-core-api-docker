FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /app

EXPOSE 5000
EXPOSE 5001

COPY *.sln .
COPY ./ApiDocker/ApiDocker.csproj /app/ApiDocker/
RUN dotnet restore "dotnet-core-api-docker.sln"

COPY . .

RUN dotnet build

FROM build AS publish

WORKDIR /app

RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS runtime

WORKDIR /app
COPY --from=publish /app/out ./

ENTRYPOINT ["dotnet", "ApiDocker.dll"]