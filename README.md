# API Gateway with Ocelot

This project implements an API gateway using Ocelot to route requests to the School Management API and Restaurants API projects based on defined configurations in the `ocelot.json` file.

## Overview

The API gateway is responsible for forwarding incoming requests to the respective downstream services, providing a unified entry point for clients.

## Configuration

The `ocelot.json` file contains the configuration for routing requests to the School Management API and Restaurants API:

```json
{
  "Routes": [
    // Configuration for the School Management API project
    {
      "DownstreamPathTemplate": "/api/School/{everything}",
      "DownstreamScheme": "https",
      "DownstreamHostAndPorts": [
        {
          "Host": "localhost",
          "Port": 7246
        }
      ],
      "UpstreamPathTemplate": "/apigateway/SchoolService/{everything}",
      "UpstreamHttpMethod": [ "GET", "PUT", "POST", "DELETE" ]
    },
    // Configuration for the Restaurant API project
    {
      "DownstreamPathTemplate": "/api/Restaurants/{everything}",
      "DownstreamScheme": "https",
      "DownstreamHostAndPorts": [
        {
          "Host": "localhost",
          "Port": 7283
        }
      ],
      "UpstreamPathTemplate": "/apigateway/RestaurantsService/{everything}",
      "UpstreamHttpMethod": [ "GET", "PUT", "POST", "DELETE" ]
    }
  ]
}
```


## Usage
To use this API gateway, follow these steps:

1. Clone this repository.
2. Configure the ocelot.json file to match your desired routing configuration.
3. Build and run the API gateway project.
   
## Dependencies
Ocelot - A .NET API Gateway.
