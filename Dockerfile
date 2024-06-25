#FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
#WORKDIR /app

#COPY . .
#RUN dotnet restore
#RUN dotnet publish -c Release -o out

#FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS runtime
#WORKDIR /app
#COPY --from=build /app/out .
#ENTRYPOINT ["dotnet", "api_interview.dll"]
# Use the official .NET 8.0 SDK image as a build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Set the working directory
WORKDIR /app

# Copy the project files
COPY . .

# Restore dependencies
RUN dotnet restore

# Build the project
RUN dotnet build --no-restore -c Release

# Use the official .NET runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

# Set the working directory
WORKDIR /app

# Copy the build output from the build stage
COPY --from=build /app .

# Expose the port the app runs on
EXPOSE 80

# Run the application
ENTRYPOINT ["dotnet", "api_interview.dll"]