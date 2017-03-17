# Use the standard Microsoft .NET Core container
FROM microsoft/aspnetcore:1.1.1
 
# Copy our code from the "/release" folder to the "/app" folder in our container
WORKDIR /app
COPY /bin/Debug/netcoreapp1.1/publish /app
 
# Expose port 80 for the Web API traffic
EXPOSE 80

 
# Build and run the dotnet application from within the container
ENTRYPOINT ["dotnet", "webapi-sample.dll"]