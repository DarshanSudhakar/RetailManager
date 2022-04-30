# RetailManager

## Introduction
This project is based on [TimCo Retail Manager] course done by Tim Corey

In this project, you will learn about architectural implementation of a multi-tier application. This is crucial for any technical C# and .NET interview.

Pointing out some of the salient features of the project
- Usage of Swagger
- Creating a WPF client application
- Usage of Dapper for data access
- Usage of Caliburn micro for dependency injection
- Creation of Data project

Currently, there are few pending items that needs to be done. The pending items list are as follows
- Creation of CI and CD
- Publishing the WPF application
- Azure Devops
- Migrating to .NET Core

## Getting started
If you thinking how to get started? 
Then, head on to the branches section and look out for **phase1**. The latest code is merged to  **phase1** branch.

As and when the video is covered in the [TimCo Retail Manager] playlist; a corresponding pull request is made to phase1 branch. 

For example, lets say I have watched the Video 17 - [Display Product Data - A TimCo Retail Manager Video] on the [TimCo Retail Manager] playlist. You would see a branch with the same number on this Github repo and a corresponding pull request initiated.

![image](https://user-images.githubusercontent.com/8463823/126734226-fb411c33-16fd-4861-8f5b-afdd34d813a8.png)

> :warning: Note: Please note that the this pattern is not followed for the first few videos. However from video number 14 this has be religiously practised.

[Display Product Data - A TimCo Retail Manager Video]: <https://www.youtube.com/watch?v=boDpqLwviQc&list=PLLWMQd6PeGY0bEMxObA6dtYXuJOGfxSPx&index=17>

[TimCo Retail Manager]: <https://www.youtube.com/user/IAmTimCorey/playlists>

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
