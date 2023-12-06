test:
	dotnet test \
		--collect:"XPlat Code Coverage;Format=lcov" \
		--settings coverlet.runsetting

process-test-coverage:
	dotnet tool restore
	dotnet tool run reportgenerator \
		-reports:${path} \
		-targetdir:coverage/html
