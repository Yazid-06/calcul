# Étape 1 : On compile l'app avec le SDK 9.0
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY . .
RUN dotnet restore
# On compile en mode Release
RUN dotnet publish -c Release -o /app/publish

# Étape 2 : On prépare le serveur avec le Runtime 9.0
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build /app/publish .

ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

ENTRYPOINT ["dotnet", "CalculPourcentage.dll"]