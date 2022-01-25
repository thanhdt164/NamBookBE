using Dapper;
using DTT.BookStore.Core.Enum;
using DTT.BookStore.Core.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTT.BookStore.Infrastructure.Repositories
{
    public class DashboardRepository : BaseRepository<object>, IDashboardRepository
    {

        public DashboardRepository(IConfiguration  configuration) : base(configuration) { }

        public IEnumerable<object> getBookImport(DateTime fromTime, DateTime toTime)
        {
            var parameter = new DynamicParameters();
            parameter.Add($"@fromTime", fromTime);
            parameter.Add($"@toTime", toTime);
            var results = _dbConnection.Query<object>($"Proc_GetBookImport", param: parameter, commandType: CommandType.StoredProcedure);
            return results;
        }

        public IEnumerable<object> reportRevenueAndSpending(DateTime fromTime, DateTime toTime)
        {
            var parameter = new DynamicParameters();
            parameter.Add($"@fromTime", fromTime);
            parameter.Add($"@toTime", toTime);
            var results = _dbConnection.Query<object>($"Proc_ReportRevenueAndSpending", param: parameter, commandType: CommandType.StoredProcedure);
            return results;
        }

        public IEnumerable<object> getTopBookSold(DateTime fromTime, DateTime toTime, int top)
        {
            var parameter = new DynamicParameters();
            parameter.Add($"@fromTime", fromTime);
            parameter.Add($"@toTime", toTime);
            parameter.Add($"@top", top);
            var results = _dbConnection.Query<object>($"Proc_GetTopBookSold", param: parameter, commandType: CommandType.StoredProcedure);
            return results;
        }

        public IEnumerable<object> getSpending(DateTime fromTime, DateTime toTime, int reportType)
        {
            var parameter = new DynamicParameters();
            parameter.Add($"@fromTime", fromTime);
            parameter.Add($"@toTime", toTime);
            if (reportType == 1)
            {
                var results = _dbConnection.Query<object>($"Proc_GetSpendingByMonth", param: parameter, commandType: CommandType.StoredProcedure);
                return results;
            }
            else
            {
                var results = _dbConnection.Query<object>($"Proc_GetSpendingByYear", param: parameter, commandType: CommandType.StoredProcedure);
                return results;
            }
        }

        public IEnumerable<object> getRevenue(DateTime fromTime, DateTime toTime, int reportType)
        {
            var parameter = new DynamicParameters();
            parameter.Add($"@fromTime", fromTime);
            parameter.Add($"@toTime", toTime);
            if (reportType == 1)
            {
                var results = _dbConnection.Query<object>($"Proc_GetRevenueByMonth", param: parameter, commandType: CommandType.StoredProcedure);
                return results;
            }
            else
            {
                var results = _dbConnection.Query<object>($"Proc_GetRevenueByYear", param: parameter, commandType: CommandType.StoredProcedure);
                return results;
            }
        }
    }
}
