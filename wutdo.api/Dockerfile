FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["wutdo.api/wutdo.api.csproj", "wutdo.api/"]
RUN dotnet restore "wutdo.api/wutdo.api.csproj"
COPY . .
WORKDIR "/src/wutdo.api"
RUN dotnet build "wutdo.api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "wutdo.api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "wutdo.api.dll"]