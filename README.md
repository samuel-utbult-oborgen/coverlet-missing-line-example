1. Run either `dotnet test --collect:"XPlat Code Coverage;Format=lcov"` or
`make test` in the repository root.
2. Open ExampleProject.Tests/TestResults/[GUID]/coverage.info
3. Line 21 should be `DA:3,0`.
