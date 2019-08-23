using Dapper;
using System.Collections.Generic;
using System.Data;
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

        public IEnumerable<MiniExcursionDao> GetAllExcursions()
        {
            IEnumerable<MiniExcursionDao> miniExcursionDao = null;

            using (var connection = new SqlConnection(connectionString))
            {
                miniExcursionDao = connection.Query<MiniExcursionDao>(
                    StoredProcedures.SelectAll,
                    commandType: CommandType.StoredProcedure);
            }

            return miniExcursionDao;
        }

        public MiniExcursionDao GetExcursionById(int id)
        {
            MiniExcursionDao miniExcursionDao = null;

            using (var connection = new SqlConnection(connectionString))
            {
                miniExcursionDao = connection.QueryFirstOrDefault<MiniExcursionDao>(
                    StoredProcedures.SelectById,
                    new { idMiniExcursion = id },
                    commandType: CommandType.StoredProcedure);
            }

            return miniExcursionDao;
        }

        public void InsertMiniExcursion(MiniExcursionDao MiniExcursion)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(
                    StoredProcedures.Insert,
                    new
                    {
                        MiniExcursion.libelleMiniExcursion,
                        MiniExcursion.nombrePlaceMiniExcursion
                    },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateMiniExcursion(MiniExcursionDao MiniExcursion)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(
                    StoredProcedures.Update,
                    new
                    {
                        MiniExcursion.idMiniExcursion,
                        MiniExcursion.libelleMiniExcursion,
                        MiniExcursion.nombrePlaceMiniExcursion
                    },
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public void DeleteMiniExcursion(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(
                    StoredProcedures.Delete,
                    new { @idMiniExcursion = id },
                    commandType: CommandType.StoredProcedure);
            }
        }

        private static class StoredProcedures
        {
            internal const string SelectAll = "ps_miniexcursions_select_all";
            internal const string SelectById = "ps_miniexcursion_select_by_id";
            internal const string Insert = "ps_miniexcursion_insert";
            internal const string Update = "ps_miniexcursion_update";
            internal const string Delete = "ps_miniexcursion_delete";
        }
    }
}
