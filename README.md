
## Run The Project
You will need the following tools:

* [Visual Studio 2019](https://visualstudio.microsoft.com/downloads/)
* [.Net Core 3.1 or later](https://dotnet.microsoft.com/download/dotnet-core/3.1)
* [Docker Desktop](https://www.docker.com/products/docker-desktop)

### Installing
Follow these steps to get your development environment set up: (Before Run Start the Docker Desktop)
1. Clone the repository
2. At the root directory which include **docker-compose.yml** files, run below command:
```csharp
docker-compose -f docker-compose.yml -f docker-compose.override.yml up –d
```
3. Wait for docker compose all microservices. That’s it! 
4. Once all the microservices are running, browser the following API gateway urls to get list of users and attributes,
```csharp
http://localhost:7000/Users
http://localhost:7000/Attributes
```
5. To access the swagger for individual APIs, use following urls,
```csharp
### BMS Admin API ### - http://localhost:8001/swagger/index.html
### BMS Master API ### - http://localhost:8002/swagger/index.html
```