FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ["LibrarySystem.csproj", "./"]
RUN dotnet restore "LibrarySystem.csproj"

COPY . ./
RUN dotnet publish "LibrarySystem.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/runtime:8.0
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "LibrarySystem.dll"]
