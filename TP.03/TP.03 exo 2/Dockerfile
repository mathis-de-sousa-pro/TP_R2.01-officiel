FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["TP.03 exo 2/TP.03 exo 2.csproj", "TP.03 exo 2/"]
RUN dotnet restore "TP.03 exo 2/TP.03 exo 2.csproj"
COPY . .
WORKDIR "/src/TP.03 exo 2"
RUN dotnet build "TP.03 exo 2.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "TP.03 exo 2.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TP.03 exo 2.dll"]
