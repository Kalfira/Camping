using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;

namespace BitAbridged.Services
{
    public class SqlStringBuilder : DbConnectionStringBuilder
    {
        public static void InitializeConnectionString()
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["TestConnection"];

            if (null != settings)
            {
                string initString = settings.ConnectionString;

                var builder = new SqlConnectionStringBuilder(initString);

                builder["Data Source"] = "(local)/mssqllocaldb";
                builder["Integrated Security"] = true;
                builder["AsynchronousProcessing"] = true;
                builder["AttachDbFilename"] = "|DataDirectory|/aspnet-BitAbridged-20150626103520.mdf";
                builder["Initial Catalog"] = "Initial Catalog=aspnet-BitAbridged";

            }






        }
    }
}