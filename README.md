# .NET Core Web API with Pagination and Sorting

This project is a .NET Core Web API implementation that includes pagination and sorting capabilities for retrieving entities. It enables users to paginate through the results and specify sorting criteria based on entity properties.

## Features

- **Pagination**: Allows users to paginate through the list of entities returned by the API endpoint.
- **Sorting**: Enables users to specify the sorting criteria (property name and sort order) to order the entities.
- **Flexible Configuration**: Supports customizable page size, default sorting criteria, and more.

## Usage

### Installation

1. **Clone the Repository**:

   ```bash
   git clone <repository_url>
   ```

2. **Navigate to the Project Directory**:

   ```bash
   cd EntityAPI
   ```

### Running the Application

3. **Run the Application**:

   ```bash
   dotnet run
   ```

4. **Access the API**:
   - The API will be accessible at `http://localhost:5001`.
   - Use tools like Postman or curl to send HTTP requests to the API endpoints.

## Endpoints

- **GET /api/entity**: Retrieve a list of entities with support for pagination and sorting.
  - Query Parameters:
    - `pageNumber`: Page number to retrieve (default: 1)
    - `pageSize`: Number of entities per page (default: 10)
    - `sortBy`: Property name to sort by (default: "Id")
    - `sortOrder`: Sort order ("asc" or "desc") (default: "asc")

## Contributing

Contributions are welcome! If you have suggestions, bug reports, or feature requests, please open an issue or submit a pull request.

## License

This project is licensed under the [MIT License](LICENSE).
