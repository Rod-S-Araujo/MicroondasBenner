FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

COPY . ./
RUN dotnet restore
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app-runtime
COPY --from=build /app/out .
COPY --from=build /app/microwave.db .
COPY --from=build /app/microwave.db-shm .
COPY --from=build /app/microwave.db-wal .

EXPOSE 8080
EXPOSE 8081

ENTRYPOINT ["dotnet", "MicroondasBenner.dll"]


