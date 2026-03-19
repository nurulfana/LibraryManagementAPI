# Overview

This is a Library Management Web API built with .NET 8 and Entity Framework Core. It provides a robust backend for managing a book inventory, featuring full CRUD operations and data validation.

# Features
The API exposes the following RESTful endpoints, which can be tested directly via the built-in Swagger UI:

1. Book Management (CRUD) 
   - GET /api/Books: Retrieve a complete list of all books in the library.
   - GET /api/Books/{id}: Fetch details for a specific book using its unique ID.
   - POST /api/Books: Add a new book to the inventory (includes validation to prevent future publication dates).
   - PUT /api/Books/{id}: Update the details of an existing book.
   - DELETE /api/Books/{id}: Permanently remove a book record from the database.

2. Data & Architecture
   - Add new assignment entries to the database

# Platform
- Developed using .NET 8.0, C#, Entity Framework Core
- Database used for this development is SQL Server.
- Documentation: Swagger (OpenAPI)

# Snippets of this project

<table border="1">
  <tr>
    <td>Dashboard</td>
    <td colspan="3">
      <img src="UI/Dashboard.png" style="display:block; margin:10px 0;">
      <img src="UI/Edit.png" style="display:block; margin:10px 0;">
      <img src="UI/Delete.png" style="display:block; margin:10px 0;">
    </td>
  </tr>
  <tr>
    <td>Create Assignment</td>
    <td colspan="3">
      <img src="UI/CreateAssignment.png">
    </td>
  </tr>
</table>
