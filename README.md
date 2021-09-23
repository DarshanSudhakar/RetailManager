# RetailManager
In this retail manager project to learn about architectural implementation of a multi-tier application
Here are some of the salient features of the project
- Usage of Swagger
- Creating a WPF client application
- Usage of Dapper for data access
- Usage of Caliburn micro for dependency injection
- Creation of Data project

There are few pending items like
- Creation of CI and CD
- Publishing the WPF application
- Azure Devops
- Migrating to .NET Core

The work is under progress will update this file as and when the features are completed

This project is based on [TimCo Retail Manager](https://www.youtube.com/user/IAmTimCorey/playlists) course done by Tim Corey

## Episode - 26
#### What are we doing in this episode? 
Mostly creating a API endpoints for following administration functions
- GetInventory - Creating a API endpoint to get all the inventory 
- InsertInventory - Adds a new inventory record
- GetProducts - Gets all of the product. You can use this to check which products are decrementing and which are in surplus
- GetSales - Gets a summary of sales

## Episode - 27
#### What are we doing in this episode? 
- Adding authorization attributes for all API endpoints
```C#
[Authorize(Roles = "Cashier,Admin, Manager")]
```

## Episode - 28
#### What are we doing in this episode? 
- Showing relavent message box when user is not authorized
- Implementing a new message box