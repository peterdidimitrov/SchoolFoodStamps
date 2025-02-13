# Use the official .NET 6.0 SDK image for building the application
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

# Copy project files and restore dependencies
COPY . ./
RUN dotnet restore

# Build and publish the application
RUN dotnet publish -c Release -o /publish

# Use .NET 6.0 runtime for running the app
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /publish .
EXPOSE 80
EXPOSE 443
CMD ["dotnet", "SchoolFoodStamps.Web.dll"]
