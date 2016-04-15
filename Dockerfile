FROM microsoft/aspnet:latest

ADD . /PrintJob
WORKDIR /PrintJob
RUN ["dnu","restore"]
ENTRYPOINT ["dnx","run"]
