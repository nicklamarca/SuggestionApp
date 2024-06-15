# MongoDB-Based Suggestion Application Backend Library

This is a C# backend library for a suggestion application that uses MongoDB as the database. It provides functionality for managing users, categories, statuses, and suggestions.

## Architecture

The library follows a layered architecture with the following main components:

### DbConnection

- `DbConnection` class sets up the MongoDB connection and provides access to the collections for categories, statuses, users, and suggestions.

### Data Access

The `Data Access` layer contains classes for handling CRUD operations on different entities:

#### MongoUserData

- `GetUsersAsync()`: Retrieves all user documents
- `GetUserAsync(string id)`: Retrieves a user by its ID
- `GetUserFromAuthentication(string objectId)`: Retrieves a user by authentication identifier
- `CreateUser(UserModel user)`: Inserts a new user document
- `UpdateUser(UserModel user)`: Updates an existing user document

#### MongoCategoryData

- `GetAllCategories()`: Retrieves all category documents
- `CreateCategory(CategoryModel category)`: Inserts a new category document

#### MongoStatusData

- `GetAllStatuses()`: Retrieves all status documents
- `CreateStatus(StatusModel status)`: Inserts a new status document

#### MongoSuggestionData

- `GetAllSuggestions()`: Retrieves all non-archived suggestion documents
- `GetAllAppovedSuggestions()`: Retrieves approved suggestion documents
- `GetSuggestion(string id)`: Retrieves a suggestion by ID
- `GetAllSuggestionsWaitingForAppoval()`: Retrieves suggestions waiting for approval
- `UpdateSuggestion(SuggestionModel suggestion)`: Updates an existing suggestion document
- `UpVoteSuggestion(string suggestionId, string userId)`: Upvotes or removes upvote from a suggestion
- `CreateSuggestion(SuggestionModel suggestion)`: Inserts a new suggestion document and updates the user's authored suggestions
- `GetUsersSuggestions(string userId)`: Retrieves suggestions authored by a user

### Transaction Operations

- `MongoSuggestionData` performs transactions for creating suggestions and upvoting suggestions to maintain data consistency across multiple collections (suggestions and users).

### In-Memory Cache

- An in-memory cache is used to improve performance for frequently accessed data, such as categories, statuses, and suggestions.

## Usage

1. Set up the MongoDB connection using the `DbConnection` class.
2. Use the respective classes from the `Data Access` layer to perform CRUD operations on users, categories, statuses, and suggestions.
3. For creating suggestions and upvoting suggestions, use the transaction operations provided by the `MongoSuggestionData` class.

## Dependencies

- `MongoDB.Driver`
- `Microsoft.Extensions.Caching.Memory`
- `Microsoft.Extensions.Configuration.Abstractions`

## Contributing

Contributions are welcome! Please open an issue or submit a pull request.
