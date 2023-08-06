# FitnessAppWebApi
simple micro service using .NET framwork

A deployment diagram in software engineering is a type of diagram within the Unified Modeling Language (UML) that illustrates the physical deployment of software artifacts (e.g., components, modules, executables) to hardware nodes (e.g., servers, machines, devices) and their interconnections.
Below diagram depicts the fitness application which scales and follows a  micro service architect. As shown in the diagram there is a separate client application which is already deployed in monolithic architecture which was developed using the .net framework and used in- memory database. In the new application it uses REST API calls to communicate with API Gateway service. This application uses two micro services one for user related services and other for  meal and workout service both micro services use a separate MS SQL database. When API gateway receives user related service activity then it will be redirected to User server and if it is related to meal or workout then redirected to meal and workout server

![dp](https://github.com/kanishka-dot/FitnessAppWebApi/assets/57704517/38fc0eb7-0eb5-4792-aaf0-caec8b2cdd53)
