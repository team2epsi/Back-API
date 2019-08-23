using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using Dapper;

namespace Loclandes.data
{
    public class MiniExcursionDal : IMiniExcursionDal
    {

        public string connectionString;

        public MiniExcursionDal(string _connectionString)
        {
            connectionString = _connectionString;
        }

        public IEnumerable<MiniExcursionDao> GetAllMiniExcursions()
        {
            IEnumerable<MiniExcursionDao> miniExcursionDao = null;
            using (var connection = new SqlConnection(connectionString))
            {
                miniExcursionDao = connection.Query<MiniExcursionDao>("SELECT * FROM MiniExcursions");
            }

            return miniExcursionDao;
        }

        public IEnumerable<MiniExcursionDao> GetMiniExcursionById(int id)
        {
            IEnumerable<MiniExcursionDao> miniExcursionDao = null;
            using (var connection = new SqlConnection(connectionString))
            {
                var miniExcusrionId = id;
                miniExcursionDao = connection.Query<MiniExcursionDao>("SELECT* FROM MiniExcursions where idMiniExcursion=" + miniExcusrionId);
            }

            return miniExcursionDao;
        }

        public void AddMiniExcursion(MiniExcursionDao mini)
        {
            // Version simple
            //using (var connection = new SqlConnection(connectionString))
            //{
            //    string sQuery = "INSERT INTO MiniExcursions (libelleMiniExcursion, nombrePlaceMiniExcursion)" + "VALUES(@libelleMiniExcursion, @nombrePlaceMiniExcursion)";
            //    connection.Open();
            //    connection.Execute(sQuery, mini);
            //}
                
            // Version avec PS
            using (var connection = new SqlConnection(connectionString))
            {
                string ps_miniexcursion_insert = "ps_miniexcursion_insert";

                connection.Execute(ps_miniexcursion_insert, new { @libelleMiniExcursion  = mini.LibelleMiniExcursion, @nombrePlaceMiniExcursion = mini.NombrePlaceMiniExcursion }, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteMiniExcursion(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                // connection.Open();
                string ps_miniexcursion_insert = "ps_miniexcursion_delete";

                connection.Execute(ps_miniexcursion_insert, new { @idMiniExcursion = id }, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
