using DTT.BookStore.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTT.BookStore.Core.Services
{
    public class DashboardService : BaseService<object>, IDashboardService
    {
        IDashboardRepository _dashboardRepository;
        public DashboardService(IDashboardRepository dashboardRepository) : base(dashboardRepository)
        {
            _dashboardRepository = dashboardRepository;
        }

        public IEnumerable<object> getBookImport(DateTime fromTime, DateTime toTime)
        {
            return _dashboardRepository.getBookImport(fromTime, toTime);
        }

        public IEnumerable<object> reportRevenueAndSpending(DateTime fromTime, DateTime toTime)
        {
            return _dashboardRepository.reportRevenueAndSpending(fromTime, toTime);
        }

        public IEnumerable<object> getTopBookSold(DateTime fromTime, DateTime toTime, int top)
        {
            return _dashboardRepository.getTopBookSold(fromTime, toTime, top);
        }

        public IEnumerable<object> getSpending(DateTime fromTime, DateTime toTime, int reportType)
        {
            return _dashboardRepository.getSpending(fromTime, toTime, reportType);
        }

        public IEnumerable<object> getRevenue(DateTime fromTime, DateTime toTime, int reportType)
        {
            return _dashboardRepository.getRevenue(fromTime, toTime, reportType);
        }
    }
}
