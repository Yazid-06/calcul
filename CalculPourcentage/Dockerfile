# Étape 1 : On compile l'app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY . .
RUN dotnet restore
# On compile en mode Release
RUN dotnet publish -c Release -o /app/publish

# Étape 2 : On prépare le serveur pour lancer l'app
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .

# Render a besoin que l'app écoute sur le port 8080
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

# C'est ICI que c'est important : le nom exact de ta DLL générée
ENTRYPOINT ["dotnet", "CalculPourcentage.dll"]