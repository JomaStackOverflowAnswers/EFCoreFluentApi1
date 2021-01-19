param (
    [Parameter()]
    [System.String]
    $Name
)
dotnet-ef migrations add "$Name" --startup-project "EFCoreFluentApi1" --project "EFCoreFluentApi1" --context "MyContext" --output-dir "Migrations" --verbose
#dotnet ef migrations script --output "EFCoreFluentApi1/Sql/Script.Sql" --context "MyContext" --startup-project "EFCoreFluentApi1" --project "EFCoreFluentApi1" --verbose --idempotent