#!/bin/sh

echo "Running net8.0 app"
dotnet run --configuration Release --project src/Net8.App

echo ""
echo "Running net9.0 app"
dotnet run --configuration Release --project src/Net9.App