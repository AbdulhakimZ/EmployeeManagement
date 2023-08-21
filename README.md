# RESTful API Basic CRUD

### Installation

1. Clone this repository to your local machine using:
   ```git clone https://github.com/AbdulhakimZ/EmployeeManagement.git```

   
3. Open the project in Visual Studio or Visual Studio Code.

4. Create a database named `EmployeeManagement` in your preferred database server (e.g., SQL Server).

5. Update the connection string in `appsettings.json` with your database server information:
```json
"ConnectionStrings": {
    "DefaultConnection": "Server=YourServerName;Database=EmployeeManagement;Integrated Security=True;"
}
```
5. Apply the initial migration and update the database by running the following commands on Package manager console:
   ```
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```
### Usage

1. Build and run the project from Visual Studio or Visual Studio Code.

2. I used Postman to test the API endpoints. You can use the app of your choise.

3. Set the request URL according to your local environment. For example: `https://localhost:7147/employees`

4. Use the appropriate HTTP methods (GET, POST, PUT, DELETE) to interact with the API endpoints.

5. Example To test the POST endpoint:
   - Set the request method to `POST`.
   - In the "Body" tab, select "raw" and choose `JSON (application/json)` from the dropdown.
   - Paste the employee data in the following format:
     ```json
     {
         "firstName": "Luckyman",
         "middleName": "Zeinu",
         "lastName": "Ali"
     }
     ```
   - Click "Send" to create a new employee.

6. To test other endpoints, change the HTTP method and the URL accordingly.

### API Endpoints

- `GET /api/employees`: Retrieves a list of all employees.
- `GET /api/employees/{id}`: Fetches details of a specific employee by their ID.
- `POST /api/employees`: Creates a new employee.
- `PUT /api/employees/{id}`: Updates an existing employee's information by their ID.
- `DELETE /api/employees/{id}`: Deletes an employee from the system by their ID.

