FROM microsoft/dotnet
MAINTAINER Johnie Hjelm <johnie.hjelm@cloudnine.se

RUN mkdir -p /dotnetapp

COPY . /dotnetapp

WORKDIR /dotnetapp

RUN ["dotnet", "restore"]

ENTRYPOINT ["dotnet", "run"]
