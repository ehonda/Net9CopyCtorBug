#!/bin/sh

dotnet clean --configuration Release
rm ./packages/*.nupkg
dotnet pack --configuration Release --output ./packages