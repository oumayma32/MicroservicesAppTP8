# Atelier 8 - Microservices ASP.NET Core

Projets : ProductsAPI, OrdersAPI, ApiGateway (Ocelot), Shared.
Communication asynchrone : RabbitMQ + MassTransit 8.x.

## Prerequis
- .NET 9, SQL Server LocalDB, Docker Desktop

## Lancement
1. RabbitMQ :
   docker run -d --hostname my-rabbit --name ecomm -p 15672:15672 -p 4001:5672 rabbitmq:3-management
2. Bases de donnees (projet par defaut ProductsAPI, puis OrdersAPI) :
   Update-Database
3. Lancer les 3 projets (ProductsAPI 7066, OrdersAPI 7065, ApiGateway 7162)
4. Tester : GET/POST https://localhost:7162/apigateway/Products
5. Console RabbitMQ : http://localhost:15672 (guest / guest)