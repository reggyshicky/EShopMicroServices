# EShopMicroServices
- This Microservices implements e-commerce application entailing modules which are Catalog, Basket, Discount and Ordering microservices with NoSQL (DocumentDb, Redis) and Relational databases (PostgreSQL, Sql Server) while communicating over RabbitMQ Event Driven Communication and using Yarp API Gateway.

# CONTENT (Key Backend Concepts were covered in this project)
- ASPNET Core 8 Web API Development of Microservices
- ASPNET Minimal APIs and latest features of .Net8 and C# 12
- Vertical Slice Architecture implementation with Feature folders
- CQRS implementation using MediatR library
- CQRS Validation Pipeline Behaviours with MediatR and FluentValidation
- Marten library for .NET Transactional Document DB on PostgreSQL
- Carter Library for Minimal API endpoint definition
- Using Redis as a Distributed Cache over Basketdb
- Implemented Proxy, Decorator and Cache-aside Design Patterns
- Built a Highly Performant inter-service gRPC Communication with Basket Microservice
- Consume Discount Grpc Service for inter-service sync communication to calculate product final price
- Published BasketCheckout Queue with using MassTransit and RabbitMQ
- PostgreSQL database connection and containerization
- Implementing DDD, CQRS, and Clean Architecture with using Best Practices
- Tactical Domain-Driven Design: Entities, Value Objects, Aggregates, Agg. Roots
- Developing CQRS with using MediatR, FluentValidation and Mapster packages
- Used Entity Framework Core ORM and auto migrate to SqlServer when application startup
- Entity Framework Core Code-First Approach, Migrations, DDD Entity Configurations in Clean Architecture implementation
- Async Microservices Communication with RabbitMQ Message-Broker Service
- Used RabbitMQ Publish/Subscribe Topic Exchange Model
- Consumed RabbitMQ BasketCheckout event queue with using MassTransit-RabbitMQ Configuration
- Used MassTransit for abstraction over RabbitMQ Message-Broker system
- API Gateways with Yarp Reverse Proxy applying Gateway Routing Pattern
- Yarp Reverse Proxy Configuration; Route, Cluster, Path, Transform, Destinations
- Rate Limiting with FixedWindowLimiter on Yarp Reverse Proxy Configuration
- ASPNET Core Web Application with Bootstrap 4 and Razor template
- Consumed YarpApiGateway APIs using Refit Library with Generated HttpClientFactory
- Cross-cutting concerns Logging, global Exception Handling and Health Checks
- Dockerfile and docker-compose file for running Multi-container Docker environment
