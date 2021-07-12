using System;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;

namespace Video_Rental_Software
{
    [TestClass()]
    public class SqlDatabaseSetup
    {

        [AssemblyInitialize()]
        public static void InitializeAssembly(TestContext ctx)
        {
            // Setup the test database based on setting in the
            // configuration file
            SqlDatabaseTestClass.TestService.DeployDatabaseProject();
            SqlDatabaseTestClass.TestService.GenerateData();
        }

    }

    public class TestContext
    {
    }

    internal class AssemblyInitializeAttribute : Attribute
    {
    }

    internal class TestClassAttribute : Attribute
    {
    }
}
