#!/usr/bin/env bash
dotnet new console -o ./2-new-project
dotnet build ./2-new-project
dotnet run --project=./2-new-project
