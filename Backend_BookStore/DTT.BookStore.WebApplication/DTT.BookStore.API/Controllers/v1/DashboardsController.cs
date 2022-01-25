using DTT.BookStore.Core.Interfaces;
using DTT.BookStore.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTT.BookStore.API.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class DashboardsController : BaseEntityController<object>
    {
        IDashboardService _dashboardService;

        public DashboardsController(IDashboardService dashboardService) : base(dashboardService)
        {
            _dashboardService = dashboardService;
        }

        [HttpGet("reportRevenueAndSpending")]
        public IActionResult reportRevenueAndSpending(DateTime fromTime, DateTime toTime)
        {
            return Ok(_dashboardService.reportRevenueAndSpending(fromTime, toTime));
        }

        [HttpPost("getTopBookSold")]
        public IActionResult getTopBookSold([FromBody] ParamGetTopBookSold param)
        {
            return Ok(_dashboardService.getTopBookSold(param.fromTime, param.toTime, param.top));
        }

        [HttpPost("getBookImport")]
        public IActionResult getBookImport([FromBody] ParamGetBookImport param)
        {
            return Ok(_dashboardService.getBookImport(param.fromTime, param.toTime));
        }

        [HttpPost("getSpending")]
        public IActionResult getSpending([FromBody] ParamGetSpendingAndRevenue param)
        {
            return Ok(_dashboardService.getSpending(param.fromTime, param.toTime, param.reportType));
        }

        [HttpPost("getRevenue")]
        public IActionResult getRevenue([FromBody] ParamGetSpendingAndRevenue param)
        {
            return Ok(_dashboardService.getRevenue(param.fromTime, param.toTime, param.reportType));
        }
    }
}
