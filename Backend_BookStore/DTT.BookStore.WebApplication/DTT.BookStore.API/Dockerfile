#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["DTT.BookStore.API/DTT.BookStore.API.csproj", "DTT.BookStore.API/"]
RUN dotnet restore "DTT.BookStore.API/DTT.BookStore.API.csproj"
COPY . .
WORKDIR "/src/DTT.BookStore.API"
RUN dotnet build "DTT.BookStore.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DTT.BookStore.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DTT.BookStore.API.dll"]