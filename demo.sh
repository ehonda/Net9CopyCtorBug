#!/bin/sh

echo "Running net8.0 app"
dotnet run --configuration Release --project src/Net8.Application

echo ""
echo "Running net9.0 app"
dotnet run --configuration Release --project src/Net9.Application