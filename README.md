## TODO
1. Make api endpoints
2. Learn the structures for different templates
3. Make razors
## Ecommerce
An all purpose web app that will serve as a generic shoping app.

## Tech stack
- Dotnet
- Postgres
- docker (for containerization)

## Issues
- User permission error that stops migrations creation and database update.


## models
### Category
- ID
- Name
- Description
- Products (one to many field)

### Order
- Id
- UserId(foreign key)
- TotalAmount
- Status
- ShippingAddress
- CreatedAt
- OrderItem(one to many field)

### OrderItem
- Id
- OrderId(foreign key)
- ProductId(foreign key)
- Quantity
- Price

### Product
- Id
- Name
- Description
- Price
- Stock
- ImageUrl
- CategoryId(foreign key)
- CreatedAt

## User
- Id
- Name
- Email
- PasswordHash
- CreatedAt
- Orders(one to many field)


#### generating controller
- `dotnet aspnet-codegenerator controller -name UserController -namespace ecommerce.Controllers -outDir Controllers --controllerType WebApi`

#### Installing packages
- `dotnet add package BCrypt.Net-Next`
