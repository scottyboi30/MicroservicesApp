MicroservicesApp

--run mongo on port 27017
docker run -d -p 27017:27017 --name aspnetrun-mongo mongo

--open a iteractive termninal
docker exec -it aspnetrun-mongo /bin/bash

--use 'mongo' to then open the mongo cli