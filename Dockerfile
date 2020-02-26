FROM mcr.microsoft.com/dotnet/core/runtime:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY . .
RUN dotnet restore "app/app.csproj"
WORKDIR "/src/app/"
RUN dotnet build "app.csproj" -c Release -o /app/build

FROM build AS publish
WORKDIR "/src/app/"
RUN dotnet publish "app.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR "/src/app/bin/Release/netcoreapp3.1/"
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "app.dll"]
