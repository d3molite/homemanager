FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["HomeManager.Main/HomeManager.Main.csproj", "HomeManager.Main/"]
RUN dotnet restore "HomeManager.Main/HomeManager.Main.csproj"
COPY . .
WORKDIR "/src/HomeManager.Main"
RUN dotnet build "HomeManager.Main.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HomeManager.Main.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HomeManager.Main.dll"]
