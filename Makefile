.PHONY: main, clear

main:
	dotnet build
clear:
	rm -r pov/obj
	rm -r pov/bin
	rm pov/cities.csproj
