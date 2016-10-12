#To Do List

#### Simple to do list app with tasks and categories.

#### Jill Kuchman

## Description
This app will allow users to save tasks to a to do list, divided by category. This code demonstrates one-to-many relationships.


## Technologies used
* C#
* Nancy v1.3.0
* Razor view engine
* XUnit v2.1.0
* MSSQL

## Instructions
* Clone this repository
* In PowerShell, navigate to the top level of the project directory
* Enter `> dnu restore` to restore the project dependencies
* Create the `todo` database, following the instructions below.
* Run tests with the command `> dnx test`
* Start the kestrel server with the command `> dnx kestrel`

#### Database setup instructions
* In PowerShell, enter the SQLCMD utility with the command `> sqlcmd -S "(localdb\\mssqllocaldb)"`
* Create the app production database named `todo` using these commands:

```
1> CREATE DATABASE todo;
2> GO
1> USE todo;
2> GO
1> CREATE TABLE tasks(id INT IDENTITY(1,1), description VARCHAR(255), category_id INT);
2> GO
1> CREATE TABLE categories (id INT IDENTITY (1,1), name VARCHAR(255));
2> GO
```

Testing database is a clone of this named `todo_test`
