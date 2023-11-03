# Execution instructions
To execute the microservice only the docker-compose.yml needs to be executed.

Following Steps should be executed:
- Start Docker (Port 8080 and 5432 should not be in use!)
- Open Terminal
- Switch into the project directory
- Execute following command:
  - ```docker-compose up```
- The Backend service as well as the database will boot

## Testing the Service
On ```localhost:8080/api/Weather``` a GET Request is sent over the API to the database

To easily add some entries to the database swagger was configured.
To access Swagger open ```localhost:8080/swagger/index.html```. Over the POST Method Entries can be added to the database. 
In Addition over the GET Method data can be read out of the database.
</br>
Example entry:
</br>
```location: Wien```
</br>
```temperature: 19 Grad```