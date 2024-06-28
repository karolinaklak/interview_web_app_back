# Utiliser l'image officielle .NET SDK pour construire l'application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copier le fichier .csproj et restaurer les dépendances
COPY *.csproj ./
RUN dotnet restore

# Copier tout le reste et construire l'application
COPY . ./
RUN dotnet publish -c Release -o out

# Utiliser l'image officielle .NET runtime pour exécuter l'application
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "MyDockerApi.dll"]





