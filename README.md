# Dev.Pro Challange

Use the C# as a programming language

### Task 1: Logger

Context: Your team is working on a project where you need to log various events and errors.

You are asked to create a simple logging function that writes messages to a text file with a timestamp.

Example usage:

log_message("application.log", "User logged in", "INFO")

log_message("application.log", "Failed login attempt", "WARNING")

Expected Output in application.log:

[2023-04-24 12:34:56] [INFO] User logged in

[2023-04-24 12:35:10] [WARNING] Failed login attempt

### Task 1.1: Tests

Write tests scenarios for Logger

### Task 2: Inventory Management

Context: You are developing a simple inventory management system for a small store.

You need to create a function that takes a list of products with their names, prices, and stock levels, and returns a sorted list of products based on a given sort key (name, price, or stock) and order (ascending or descending).

Example Input:

products = [

{"name": "Product A", "price": 100, "stock": 5},

{"name": "Product B", "price": 200, "stock": 3},

{"name": "Product C", "price": 50, "stock": 10}

]

sort_key = "price"

ascending = False

Expected Output:

[

{"name": "Product B", "price": 200, "stock": 3},

{"name": "Product A", "price": 100, "stock": 5},

{"name": "Product C", "price": 50, "stock": 10}

]

How to send: You can use GitHub gist and just share a link or send a file

Note: do not create CLI applications. Just assume this is a part of a bigger application. 