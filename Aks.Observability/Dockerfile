FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Aks.Observability/Aks.Observability.csproj", "Aks.Observability/"]
RUN dotnet restore "Aks.Observability/Aks.Observability.csproj"
COPY . .
WORKDIR "/src/Aks.Observability"
RUN dotnet build "Aks.Observability.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Aks.Observability.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Aks.Observability.dll"]
