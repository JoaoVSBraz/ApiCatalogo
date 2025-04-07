# WebAPI Catalogo

ApiCatalogo is an web api built with .net 8 and managed by Entity Framework Core and PostgreSQL.

**Produtos Controller**
---

| HTTP Verb | Endpoint | Status Code | Description
| ------- | -------- | -------- | ---------- |
| POST | /produtos | 201 Created | Inserts a new product
| GET | /produtos/&#123;id:int&#125; | 200 Ok, 404 Not Found | Get a product by id
| GET | /produtos | 200 Ok | Get all products
| PUT | /produtos/&#123;id:int&#125; | 200 Ok, 404 NotFound, 400 BadRequest | Update an existing product
| DELETE | /produtos/&#123;id:int&#125; | 204 NoContent | Deletes a product

**Categorias Controller**
---

| HTTP Verb | Endpoint | Status Code | Description
| ------- | -------- | -------- | ---------- |
| POST | /categorias | 201 Created | Inserts a new category
| GET | /categorias/&#123;id:int&#125; | 200 Ok, 404 Not Found | Get a category by id
| GET | /categorias | 200 Ok | Get all categories
| GET | /categorias/produtos | 200 OK | Get categories and products
| PUT | /categorias/&#123;id:int&#125; | 200 Ok, 404 NotFound, 400 BadRequest | Update an existing category
| DELETE | /categorias/&#123;id:int&#125; | 204 NoContent | Deletes a category

## Contents

- [Overview](#overview)
- [Learnings](#learnings)
	- [Dependency Injection and Inversion of Control](#dependency-injection-and-invertion-of-control)	
	- [Entity Framework Core](#entity-framework-core)
- [Next Steps](#next-steps)
- [Reference](#refereces)

## Overview
ApiCatalogo is an web api built with .net 8, entity framework core and postgresql to manage and catalog categories and products.

## Learnings

### Dependency Injection and Inversion of Control
Dependency Injection is a technique to achieve the implementation of the Inversion of Control principle. The principle says to always depend on abstractions rather than concret implementations.

The .NET platform by default has a container to register dependencies and achieve the inversion of control which helps to create applications desacoppled and more testable.

### Entity Framework Core
Entity Framework Core is an technology created by Microsoft and used as Object Relational Mapping to abstract the data access layer to dotnet objects. Here, it is used to manage a postgresql database through migrations.

Most used Entity Framework Core CLI commands
```cmd
dotnet ef migrations add <name>
dotnet ef migrations remove <name>
dotnet ef database update
dotnet ef database drop
```
## Next Steps

## References