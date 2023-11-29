# Use the official .NET SDK image as a build stage.
# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

# workdir for souce code (compilation)
WORKDIR /source

# copy csproj and restore as distinct layers
COPY wlc2/*.sln .
COPY wlc2/wlc2/*.csproj ./wlc2/
RUN dotnet restore

# copy everything else and build app
COPY ["wlc2/wlc2/.", "./wlc2/"]
WORKDIR /source/wlc2
RUN dotnet publish -c Release -o /out

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
WORKDIR /app
COPY --from=build /out ./
# COPY ["entrypoint.sh", "."]
# RUN dotnet tool install --global dotnet-ef --version 6.0.7
# RUN chmod +x ./entrypoint.sh
# CMD /bin/bash ./entrypoint.sh

# https://stackoverflow.com/questions/74601743/docker-sql-server-login-problem-authenticationexception-the-remote-certificate
RUN sed -i 's/DEFAULT@SECLEVEL=2/DEFAULT@SECLEVEL=1/g' /etc/ssl/openssl.cnf

ENTRYPOINT ["dotnet", "wlc2.dll"]
