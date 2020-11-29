
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
docker-compose -f docker-compose.yml -f docker-compose.override.yml up �d
```
3. Wait for docker compose all microservices. That�s it! (some microservices need extra time to work so please wait if not worked in first shut)