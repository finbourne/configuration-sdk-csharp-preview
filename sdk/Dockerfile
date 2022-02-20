FROM mcr.microsoft.com/dotnet/core/sdk:3.1

RUN mkdir -p /usr/src
WORKDIR /usr/src

COPY Finbourne.Configuration.Sdk.sln /usr/src/
COPY Finbourne.Configuration.Sdk/Finbourne.Configuration.Sdk.csproj /usr/src/Finbourne.Configuration.Sdk/
RUN dotnet restore Finbourne.Configuration.Sdk

ENV FBN_CONFIGURATION_API_URL ${FBN_CONFIGURATION_API_URL}

# ENTRYPOINT [ "/bin/bash" ]
ENTRYPOINT dotnet build --configuration Release --verbosity normal Finbourne.Configuration.Sdk