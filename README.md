# _Portland Dog Park Api_

#### _A C# web api for Portland dog parks , 1-November-2019_

#### By _**Jason Huels**_

## Description

_A C# web api that allows users to create / read / update / delete dogparks from the api's MySQL database_

- GET api/dogparks : allows users to get all dog parks from the api
- GET api/dogparks?name=X&area=X&address=X&hours=X : optional search criteria, replace X with search parameters
- GET api/dogparks/id : get a specific dog park by id (replace 'id' with integer id)
- POST api/dogparks : add a new dog park to the api database
- PUT api/dogparks/{id} : update the id of dogpark in the database
- PATCH api/dogparks/{id} : update the hours of the dog park in the database
- DELETE api/dogparks/{id} : delete the specific dog park from the database

_Further Exploration:_
- Add Swagger UI : localhost:5000/swagger 

## Specifications

| Behavior | Input | Output|
|:------|:---------:|:------:|

## Setup/Installation Requirements_

* _Clone this repository_
* _Navigate to the directory_
* _Run "dotnet ef migrations add ???" command (replacing ??? with a unique name)_
* _Run "dotnet ef database update"_
* _Run "dotnet run" command to open application in the command console_

## Known Bugs

* N/A

## Support and contact details

_jasonhuels@yahoo.com_

## Technologies Used

_C#, ASP.NET, MySQL, Entity_

### License

*open source*

Copyright (c) 2019 **_Jason Huels_**