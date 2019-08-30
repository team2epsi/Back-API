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
                        MiniExcursion.LibelleMiniExcursion,
                        MiniExcursion.NombrePlaceMiniExcursion
                    },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public int UpdateMiniExcursion(MiniExcursionDao MiniExcursion)
        {
            int affectedRows = 0;

            using (var connection = new SqlConnection(connectionString))
            {
                 affectedRows= connection.Execute(
                    StoredProcedures.Update,
                    new
                    {
                        MiniExcursion.IdMiniExcursion,
                        MiniExcursion.LibelleMiniExcursion,
                        MiniExcursion.NombrePlaceMiniExcursion
                    },
                    commandType: System.Data.CommandType.StoredProcedure);
            }

            return affectedRows;
        }

        public int DeleteMiniExcursion(int id)
        {
            int affectedRows = 0;

            using (var connection = new SqlConnection(connectionString))
            {
                affectedRows = connection.Execute(
                    StoredProcedures.Delete,
                    new { @idMiniExcursion = id },
                    commandType: CommandType.StoredProcedure);
            }

            return affectedRows;
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
