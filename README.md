## Getting Started with .NET Core and Docker

This short tutorial, assumes that you have Docker and Docker Compose installed and configured. The easiest way to get them is through [Docker](https://www.docker.com/)

If you are wondering what is [.NET Core](https://www.microsoft.com/net/core/platform) , it's a new set of runtime, library and compiler components for creating web applications and services that run on Windows, Linux and Mac. Moreover, it is fully open source!

## Get started

Clone the repository

```
$ git clone git@github.com:johnie/dotnet-docker-example.git
```

Build the Dockerfile
```
$ docker build -it dotnetapp .
```

Run the image
```
$ docker run dotnetapp
```

The output should be:
```
Project dotnetapp (.NETCoreApp,Version=v1.0) will be compiled because expected outputs are missing
Compiling dotnetapp for .NETCoreApp,Version=v1.0

Compilation succeeded.
    0 Warning(s)
    0 Error(s)

Time elapsed 00:00:01.7033755



        Dotnet-bot: Welcome to using .NET Core!
.NET Core with Docker

        .
        :
     ___:____     |'\/'|
   ,'        `.    \  /
   |  O        \___/  |
 ~^~^~^~^~^~^~^~^~^~^~^~^~

**Environment**
Platform: .NET Core 1.1
OS: Linux 4.4.27-moby #1 SMP Wed Oct 26 14:21:29 UTC 2016
```
