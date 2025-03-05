# For Entity Framework Core and SQL Server

dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools

# For Identity (user management)

dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
dotnet add package Microsoft.AspNetCore.Identity.UI

# For development tools

dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design

# Install the EF Core CLI tool globally

dotnet tool install --global dotnet-ef --version 9.\*

# Using EF Core CLI commands correctly

# Note: Always use the 'dotnet ef' prefix, not just 'ef'

# Examples:

# - Remove last migration: dotnet ef migrations remove

# - Add new migration: dotnet ef migrations add MigrationName

# - Update database: dotnet ef database update

# Troubleshooting the "ef: command not found" error:

# 1. Make sure you've installed the tool using the command above

# 2. Always use 'dotnet ef' instead of just 'ef'

# 3. Run commands from your project directory (where your .csproj file is located)

# 4. If issues persist, try restarting your terminal or IDE


dotnet ef migrations add InitialCreate
dotnet ef database update