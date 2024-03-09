## Installing RabbitMQ

Before we start creating our application, we will first need to spin up a RabbitMQ server, by making use of Docker. Given that Docker is installed, we’ll open a  command-line terminal and use the docker run command to spin up our server:

`docker run -it --rm --name rabbitmq -p 5672:5672 -p 15672:15672 rabbitmq:3.13-management`

- `--rm` : This flag specifies that the container should be automatically removed when it stops running.
- Port `5672` is the default port for AMQP communication (used by RabbitMQ clients).
- Port `15672` is the default port for the RabbitMQ management web interface.
- `rabbitmq:3.13-management` : This specifies the Docker image to use. In this case, it’s the official RabbitMQ image with the management plugin included, based on version 3.13.


In order for us to access the management UI, we open a browser window and navigate to `http://localhost:15672/` using the default login of `guest/guest`.

`http://localhost:5672/`

`https://hub.docker.com/_/rabbitmq/`

https://code-maze.com/masstransit-rabbitmq-aspnetcore/
