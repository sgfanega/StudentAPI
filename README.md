This project is to show my attempt and knowledge of simple ASP.Net Core APIs.

If you would like to use this API to see how it works, there is a small tutorial bottom.


================================================================================================
What software you'll need:

Visual Studio Code

Postman

Microsoft SQL Server Management Studio (Or any other DB, but I'm using MSS)

=================================================================================================

What do you need to understand first:

DTOs: Data Transfer Objects, essentially, you don't want to send all data to  the client, this allows you to nitpick which ones you want to be sent or be changed

DB Creation in MSS: Create a login in MSS and keep the user and password. You can do this by opening Security and then right-clicking Logins

Profiles: Utitilizes AutoMapper which Maps DbContext with our DTOs/Models

================================================================================================

Step 1: Create a login in MSS, remember the user and password.

Step 2: Clone your own repository

Step 3: Once in VSCode, open up the terminal and make sure you are inside the folder

Step 4: Migrate the DBContext by "dotnet ef migrations add <insert name of migration>"
  
Step 5: Emulate the Migration to the DB by "dotnet ef database update" 

**Note you need to go into app.json to change the Server, User and password**
