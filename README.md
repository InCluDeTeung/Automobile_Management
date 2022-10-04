# LAB1_AUTOMOBILE_MANAGEMENT


# Introduction

 - Imagine you're an employee of a car retailer named Automobile Store. Your manager has asked you to develop a Windows Forms application for automobile management (CarID, CarName, Manufacturer, Price, and ReleasedYear). The application has to support adding, viewing, modifying, and removing products—a standardized usage action verbs better known as Create, Read, Update, Delete (CRUD).
 - This lab explores creating an application using Windows Forms with .NET Core,  and C#. An "in-memory database" will be created to persist the car's data, so a collection is called List will be used for reading and managing automobile data. 
 - This lab is applying Repository and Singleton Pattern. A Repository in C# mediates between the domain and data mapping layers. It allows you to pull a record or number of records out of datasets, and then have those records to work on acting like an in-memory domain object collection, and you can also update or delete records within those data set, and the mapping code encapsulated by the Repository will carry out the appropriate operations behind the scenes.
Repository pattern C# is a way to implement data access by encapsulating the set of objects persisted in a data store and the operations performed over them, providing a more object-oriented view of the persistence layer.
 - Repository pattern C# also supports the objective of achieving a clean separation and one-way dependency between the domain and data mapping layers.

# Lab Objectives 
In this lab, you will: 

- Use the Visual Studio.NET to create Windows Forms and Class Library (.dll) project.
- Create a List of persisting cars using LinQ to Object to find cars.
- Apply passing data in WinForms application
-	Apply Repository pattern and Singleton pattern in a project
-	Add CRUD action methods to WinForms application.
-	Run the project and test the WinForms actions.
