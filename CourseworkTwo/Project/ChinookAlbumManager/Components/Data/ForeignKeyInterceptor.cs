using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Data.Common;

// This class intercepts database commands to ensure that foreign key constraints are enabled in SQLite.
public class ForeignKeyInterceptor : DbCommandInterceptor
{
    // This method is called before a non-query command (e.g., INSERT, UPDATE, DELETE) is executed.
    public override InterceptionResult<int> NonQueryExecuting(
        DbCommand command, CommandEventData eventData, InterceptionResult<int> result)
    {
        // Enable foreign keys in SQLite by prepending the PRAGMA statement to the command text.
        command.CommandText = "PRAGMA foreign_keys = ON;" + command.CommandText;
        return result;
    }

    // This method is called before a query command (e.g., SELECT) is executed.
    public override InterceptionResult<DbDataReader> ReaderExecuting(
        DbCommand command, CommandEventData eventData, InterceptionResult<DbDataReader> result)
    {
        // Enable foreign keys in SQLite by prepending the PRAGMA statement to the command text.
        command.CommandText = "PRAGMA foreign_keys = ON;" + command.CommandText;
        return result;
    }
}