using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Loclandes.data
{
    public class MiniExcursionDal : IMiniExcursionDal
    {

        public string connectionString;
        
        public MiniExcursionDal(string _connectionString)
        {
            connectionString = _connectionString;
        }

        public IEnumerable<MiniExcursionDao> Get()
        {
            IEnumerable<MiniExcursionDao> miniExcursionDao = null;
            using(var connection = new SqlConnection(connectionString))
            {
                miniExcursionDao = connection.Query<MiniExcursionDao>("SELECT * FROM MiniExcursions");
            }
            return miniExcursionDao;
        }
    }
}
