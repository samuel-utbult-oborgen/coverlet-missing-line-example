namespace ExampleProject;

public record InheritedRecord(
    int A)
    : BaseRecord(A);
