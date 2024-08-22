This project is a backend application. It is designed with a three-tier architecture, covering data access, business logic, and presentation layers. This document provides information about the general structure of the project, how it works, and how to set it up.



The project consists of the following layers:

1)Data Access

-Entities: Models corresponding to the database tables are defined here.

-DTOs (Data Transfer Objects): Data models intended to be presented to the user are located here.

2)Business

-Abstract: Interfaces used in the business logic layer are defined here.

-Repository: This is where database operations are carried out.

-Context: Database connections are configured here.

-Mapping: Data mapping between Entities and DTOs is performed here.

3)Presentation

-API: Controllers are defined here, and API documentation is provided with Swagger.

-Data Transfer App: This is where data is fetched in the presentation layer.
