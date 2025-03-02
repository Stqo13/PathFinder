FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /source

COPY *.sln ./
COPY PathFinder/*.csproj ./PathFinder/
COPY PathFinder.Common/*.csproj ./PathFinder.Common/
COPY PathFinder.Data/*.csproj ./PathFinder.Data/
COPY PathFinder.Data.Models/*.csproj ./PathFinder.Data.Models/
COPY PathFinder.Services.Data/*.csproj ./PathFinder.Services.Data/
COPY PathFinder.ViewModels/*.csproj ./PathFinder.ViewModels/

RUN dotnet restore

COPY PathFinder/* ./PathFinder/
COPY PathFinder.Common/* ./PathFinder.Common/
COPY PathFinder.Data/* ./PathFinder.Data/
COPY PathFinder.Data.Models/* ./PathFinder.Data.Models/
COPY PathFinder.Services.Data/* ./PathFinder.Services.Data/
COPY PathFinder.ViewModels/* ./PathFinder.ViewModels/

RUN dotnet publish -c release -o /app --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0

WORKDIR /app

COPY --from=build /app ./
COPY PathFinder.Data/Data/* /PathFinder.Data/Data/
COPY PathFinder/Views /Views
COPY PathFinder/Views ./Views

ENTRYPOINT ["dotnet", "PathFinder.dll"]
