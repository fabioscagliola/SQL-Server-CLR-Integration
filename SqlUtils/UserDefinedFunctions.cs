using Microsoft.SqlServer.Server;
using System;
using System.Data.SqlTypes;
using System.Reflection;

[assembly: AssemblyCompany("Fabio Scagliola")]
[assembly: AssemblyCopyright("Copyright © Fabio Scagliola 2016")]
[assembly: AssemblyProduct("SqlUtils")]
[assembly: AssemblyTitle("SqlUtils")]
[assembly: AssemblyVersion("1.0.0.0")]

public partial class UserDefinedFunctions
{
    [SqlFunction]
    public static SqlDouble MATH_ROUND(SqlDouble value, SqlInt32 digits)
    {
        SqlDouble result = new(0);

        if (!value.IsNull)
            result = new SqlDouble(Math.Round(value.Value, digits.Value));

        return result;
    }
}
