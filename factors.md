# Implemented Factors
## I. Codebase
One codebase in github created: https://github.com/Nide27/12Factor

## II. Dependencies
Due to the use of C# and .net 7, any packages used could be isolated using Nuget

## III. Config
Different configs are seperated with the appsettings.json.
Additional appsettings.Development and appsettings.Production created where different configurations are set, like e.g. the database connection.

## IV. Backing services
Database is a seperated Docker container and can easily be exchanged over the connection string set in the appsettings.

## V. Build, release, run
Build, run and release seperated with a pipeline in GitHub.
Pipeline is building and creating a Docker image. This Image is afterwards pushed to DockerHub

## VI. Processes
A API is created therefore it is a stateless process. 
The only data, in this project weather data, is stored in a seperated postgres database

## VII. Port binding
Since this project is an API, port binding is available. 
Over the Port 8080 the data can be fetched als well as pushed to the database

## VIII. Dev/prod parity
Dev and prod can be very similar, only with a merge to dev branch on github, code can be in production with the pipeline

## IX. Logs
Logs are directly printed with Console.WriteLine and not thrown to other services.

