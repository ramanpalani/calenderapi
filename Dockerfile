FROM mcr.microsoft.com/dotnet/sdk:6.0 as base
WORKDIR /app

# RUN mkdir -p ./app
# COPY . ./app
ADD ./ ./app
RUN dotnet restore "./app/calendar/calendar.csproj" --disable-parallel
RUN dotnet publish "./app/calendar/calendar.csproj" -c release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
ENV DOTNET_URLS=http://+:80
WORKDIR /app
COPY --from=base /app .
ENTRYPOINT ["dotnet", "calendar.dll"]
