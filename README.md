# eCommerce CRUD API Overview
This project is an assignment to create a basic API for managing products in an e-commerce application. The API endpoints should allow for basic CRUD operations (Create, Read,
Update, Delete) on products.


Tech Stack & Design Considerations This is a .net Core 8.0 web api project - that revolves around Command Query Request Segregation (CQRS) design pattern.

Data Storage We used Entity Framework Core to communicate with database. Information about products is kept into Microsoft SQL Server.

Project Hierarchy and Architecture
This section outlines the structure and interrelationships of the projects within the solution. Our solution consists of several key projects, each serving a specific role within the overall application architecture.

# Api
Type: ASP.NET Core Web Application Purpose : Exposes five endpoints

For validation, we use FluentValidation For Mediator - 
we use 
HumbleMediator 
Logging - SeriLog 
Dependency injection - SimpleInjector

 Endpoint - POST /api/Products
 
 Endpoint - GET /api/Products
 
 Endpoint - GET /api/Products/{id}
 
 Endpoint - PUT /api/Products/{id}
 
 Endpoint - DELETE /api/Products/{id}
 

Defined in the ProductssController - the endpoints accept the command and relays it to mediator to execute the command.

# Application
Type: .NET Core Class Library Purpose : Defines the Command Handlers and include validation using FluentValidation. CommandValidators are used to verify that input is correct, e.g. if CreateProductCommand.Price is valid or not.

For Logging and validation - we inject decorators.


# Infrastructure
Type: .NET Core Class Library Purpose : stores the transaction information into database.


# tests/UnitTests
Type: .net core console applcication Purpose : Implements tests starting with Request validation, then checking the Product


please open Products.postman_collection.json file and import and then hit the endpoints

# Start the application
The default API endpoints should be testable from the [Swagger UI](http://localhost:5000/swagger/index.html).
Project runs on http://localhost:5000/ when running locally




Enjoy!
