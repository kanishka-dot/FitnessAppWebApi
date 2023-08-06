# FitnessAppWebApi
simple micro service using .NET framwork
This is fitness application api calls writen following  micro service application architecure using C# language.
Below is a class diagram which depicts the architecture of the application and this is a enhancement of a monolithic application to micro service application so the functionality of the application not change so the classes of application exist as it.
![domian-1](https://github.com/kanishka-dot/FitnessAppWebApi/assets/57704517/36d67d95-2dad-4f85-9be2-fef9049075ee)




A deployment diagram in software engineering is a type of diagram within the Unified Modeling Language (UML) that illustrates the physical deployment of software artifacts (e.g., components, modules, executables) to hardware nodes (e.g., servers, machines, devices) and their interconnections.
Below diagram depicts the fitness application which scales and follows a  micro service architect. As shown in the diagram there is a separate client application which is already deployed in monolithic architecture which was developed using the .net framework and used in- memory database. In the new application it uses REST API calls to communicate with API Gateway service. This application uses two micro services one for user related services and other for  meal and workout service both micro services use a separate MS SQL database. When API gateway receives user related service activity then it will be redirected to User server and if it is related to meal or workout then redirected to meal and workout server

![dp](https://github.com/kanishka-dot/FitnessAppWebApi/assets/57704517/711d0da0-9bd9-4844-8aaa-e7e00480945a)

