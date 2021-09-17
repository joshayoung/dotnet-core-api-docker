#!/bin/bash
./wait-for-it "db_server:1432" -t 60 -- dotnet ApiDocker.dll
