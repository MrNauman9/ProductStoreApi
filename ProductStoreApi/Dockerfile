FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build #image 
WORKDIR /app  

# Copy the csproj and restore
COPY ProductStoreApi.csproj ./
RUN dotnet restore "./ProductStoreApi.csproj"

# Copy the rest of the code
COPY . ./
RUN dotnet publish -c Release -o out

# Runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

ENTRYPOINT ["dotnet", "ProductStoreApi.dll"]
