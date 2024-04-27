FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5129

ENV ASPNETCORE_URLS=http://+:5129

USER app
FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG configuration=Release
WORKDIR /src
COPY ["KhaPOS-BE.csproj", "./"]
RUN dotnet restore "KhaPOS-BE.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "KhaPOS-BE.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "KhaPOS-BE.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "KhaPOS-BE.dll"]
