using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MiniExcursion_Data
{





    public class MiniExcursionProvider : IMiniExcursionProvider
    {
        private readonly string connectionString;

        public MiniExcursionProvider(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<MiniExcursion> Get()
        {
            IEnumerable<MiniExcursion> miniExcursions = null;

            using (var connection = new SqlConnection(connectionString))
            {
                miniExcursions = connection.Query<MiniExcursion>("select * from MiniExcursions ");
            }

            return miniExcursions;
        }



    }


}
