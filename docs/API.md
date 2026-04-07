# REST API Documentation

## Base URL
The base URL for all API endpoints is:
`https://api.example.com/v1`

## Authentication
All API calls require authentication via a Bearer token. Include the token in the Authorization header of your requests:
`Authorization: Bearer YOUR_TOKEN_HERE`

## Endpoints

### 1. Get Products
**Endpoint:** `GET /products`

#### Example Request
```
GET https://api.example.com/v1/products
```

#### HTTP Status Codes
- `200 OK`: Success
- `401 Unauthorized`: Authentication failed
- `404 Not Found`: No products found

### 2. Create Product
**Endpoint:** `POST /products`

#### Example Request
```
POST https://api.example.com/v1/products
Content-Type: application/json

{
    "name": "New Product",
    "price": 100
}
```

#### HTTP Status Codes
- `201 Created`: Product created successfully
- `400 Bad Request`: Invalid request data
- `401 Unauthorized`: Authentication failed

## Error Responses
API may return various error responses. Here are common codes:
- `400 Bad Request`: Invalid request parameters.
- `401 Unauthorized`: Missing or invalid authentication token.
- `404 Not Found`: The requested resource does not exist.

## Rate Limiting
To prevent abuse, the API enforces rate limiting:
- Maximum of 100 requests per minute per IP address.

Ensure to handle HTTP status codes and responses accordingly in your application.