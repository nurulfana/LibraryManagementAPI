# Overview

This is a Library Management Web API built with .NET 8 and Entity Framework Core. It provides a backend for managing a book inventory, featuring full CRUD operations and data validation.

# Features
The API exposes the following RESTful endpoints, which can be tested directly via the built-in Swagger UI:

1. Book Management (CRUD) 
   - GET /api/Books: Retrieve a complete list of all books in the library.
   - GET /api/Books/{id}: Fetch details for a specific book using its unique ID.
   - POST /api/Books: Add a new book to the inventory (includes validation to prevent future publication dates).
   - PUT /api/Books/{id}: Update the details of an existing book.
   - DELETE /api/Books/{id}: Permanently remove a book record from the database.

# Platform
- Developed using .NET 8.0, C#, Entity Framework Core
- Database: InMemory Provider
- Documentation: Swagger / OpenApi

# Snippets of this project

<table border="1">
  <tr>
    <td>Main Page</td>
    <td colspan="3">
      <img src="screenshot=/main.png" style="display:block; margin:10px 0;">
    </td>
  </tr>
  <tr>
    <td>Create Book</td>
    <td colspan="3">
      <img src="screenshot/create.png">
      <img src="screenshot/create2.png">
    </td>
   </tr>
   <tr>
    <td>Get Book</td>
    <td colspan="3">
      <img src="screenshot/getbook.png">
    </td>
   </tr>
   <tr>
    <td>Get Books</td>
    <td colspan="3">
      <img src="screenshot/getbooks.png">
    </td>
   </tr>
   <tr>
   <td>Update Book</td>
    <td colspan="3">
      <img src="screenshot/update.png">
    </td>
   </tr>
   <tr>
    <td>Delete Book</td>
    <td colspan="3">
      <img src="screenshot/delete.png">
    </td>
   </tr>
</table>
