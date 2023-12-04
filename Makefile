test:
	dotnet test --collect:"XPlat Code Coverage;Format=lcov"
	$(MAKE) process-test-coverage

process-test-coverage:
	dotnet tool restore
	dotnet tool run reportgenerator \
		-reports:${path} \
		-targetdir:coverage/html
