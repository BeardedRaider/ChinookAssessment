using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Data.Common;

public class ForeignKeyInterceptor : DbCommandInterceptor
{
    public override InterceptionResult<int> NonQueryExecuting(
        DbCommand command, CommandEventData eventData, InterceptionResult<int> result)
    {
        // Enable foreign keys in SQLite
        command.CommandText = "PRAGMA foreign_keys = ON;" + command.CommandText;
        return result;
    }

    public override InterceptionResult<DbDataReader> ReaderExecuting(
        DbCommand command, CommandEventData eventData, InterceptionResult<DbDataReader> result)
    {
        command.CommandText = "PRAGMA foreign_keys = ON;" + command.CommandText;
        return result;
    }
}