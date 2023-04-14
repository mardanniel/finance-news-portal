# eFinancials: A finance web portal built using ASP.NET Core

## Note

This branch is specifically created for docker and kubernetes.

## Team

- Mar Danniel Ginturo
- Donita Rose Riparip

## Instructions for Docker and Kubernetes

1. Clone the repository.
2. Open a terminal (ex. Command Line, Git Bash) and change directory (using cd command) to the main directory of the solution (basically the folder where the solution file is located).

### For Docker

1. Execute the following in the command line:

```docker-compose up```

2. Open Docker Desktop to see the images and the container created. On the Containers, find the container containing the images of the Web and API project, as well as the Microsoft SQL Server. You can examine the errors just by looking through the logs.

3. To stop the container from running, click the stop button on Docker Desktop or execute the following:

```docker-compose down```

### For Kubernetes

1. Execute the following command:

```kubectl apply -f <kubernetes yaml file>```

2. To get all namespace, execute the following:

```kubectl get all -n <namespace name>```

3. To delete resources, execute the following:

```kubectl delete -f <kubernetes yaml file>```
