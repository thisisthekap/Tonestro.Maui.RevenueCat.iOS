#!/bin/bash
projects=$(cat ./projects.txt)

mkdir -p nugetoutput
rm nugetoutput/*.nupkg

for project in ${projects}; do
	cp ${project}/nugetoutput/*.nupkg ./nugetoutput/
done
