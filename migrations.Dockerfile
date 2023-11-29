# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /source

# copy csproj and restore as distinct layers
COPY wlc2/*.sln .
COPY wlc2/wlc2/*.csproj ./wlc2/
RUN dotnet restore

# copy everything else and restore libraries
COPY ["wlc2/wlc2/.", "./wlc2/"]
WORKDIR /source/wlc2
RUN dotnet restore

# add dotnet-ef tool to run migrations
RUN dotnet tool install --global dotnet-ef --version 7.0.11
ENV PATH="$PATH:/root/.dotnet/tools"