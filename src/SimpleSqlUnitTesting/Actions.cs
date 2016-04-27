using Microsoft.Data.Tools.Schema.Sql.UnitTesting;

namespace SimpleSqlUnitTesting
{
    public static class Actions
    {
        public static SqlDatabaseTestActions CreateBlock(string sql)
        {
            return new SqlDatabaseTestActions
            {
                TestAction = CreateSingle(sql)
            };
        }

        public static SqlDatabaseTestAction CreateSingle(string sql)
        {
            return new SqlDatabaseTestAction
            {
                SqlScript = sql
            };
        }
    }
}