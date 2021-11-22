# Minimal APIs In .Net 6
#####  This repository is a sample modular solution that is developed for showing the implementation of Minimal APIs in .Net 6.

**This WebApi contains the following APIs:**

1. GET  URL: "/todos"       Returns the list of Todos
2. GET URL: "/todos/{id}"  Finds and returns a Todo by Id 
3. POST URL: "/todos"      Creates a new Todo

- **This WebApi is powered by swagger.**

**The structure is created based on the clean architecture: **

- **The MinimalApi.Domain** is a class library that contains Models, DTOs, and Infrastructure's interfaces
- **The MinimalApi.Infrastructure** is a class library that contains the implementations of Infrastructure's interfaces
- **The MinimalApi.Application** is a class library that contains the logic 
- **The MinimalApi.WebApi is a WebAPI** project that implements minimal APIs - this project is set as the startup project.  
- **The MinimalApi.Test** is an XUnit test project.

**Dependencies: **
.Net Version: 6.2.3



