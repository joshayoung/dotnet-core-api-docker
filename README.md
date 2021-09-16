# dotnet-core-api-docker

#### .Net Commands:
* `dotnet new gitignore`
* `dotnet new webapi -n ApiDocker`
* `dotnet new sln`
* `dotnet sln add ApiDocker/ApiDocker.csproj`
* `dotnet build`
* `dotnet run --project ApiDocker/ApiDocker.csproj`

#### Add NuGet Packages:
* `dotnet add ApiDocker package Microsoft.EntityFrameworkCore.Design`
* `dotnet add ApiDocker package Microsoft.EntityFrameworkCore.SqlServer`

#### Docker Commands:
* `docker build -t apidocker .`
* `docker run --rm --name api-docker-container2 -p 5000:80 apidocker`

#### Docker-Compose Commands:
* `docker-compose build`
* `docker-compose up`


#### API Details:
* View Swagger Doc:
  * `https://localhost:5001/swagger/index.html`
* View Weather Forecast:
  * `http://localhost:5000/WeatherForecast`
