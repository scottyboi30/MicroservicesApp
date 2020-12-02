MicroservicesApp

--run mongo on port 27017
docker run -d -p 27017:27017 --name aspnetrun-mongo mongo

--open a iteractive termninal
docker exec -it aspnetrun-mongo /bin/bash

--use 'mongo' to then open the mongo cli

--run redis
docker run -d -p 6379:6379 --name aspnetrun-redis redis

--open redis interactive terminal
docker exec -it aspnetrun-redis /bin/bash

--use 'redi-cli' to open redis cli

--run rabbitmq
docker run -d --hostname my-rabbit --name some-rabbit -p 15672:15672 -p 5672:5672 rabbitmq:3-management

--rabbitmq managament
http://localhost:15672/   default password/username: guest 

--sql server container 
docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=REPLACE_THIS' -p 1433:1433 -d mcr.microsoft.com/mssql/server