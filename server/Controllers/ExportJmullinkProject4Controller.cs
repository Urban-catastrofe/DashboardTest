using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DashboardTest.Data;

namespace DashboardTest
{
    public partial class ExportJmullinkProject4Controller : ExportController
    {
        private readonly JmullinkProject4Context context;
        private readonly JmullinkProject4Service service;
        public ExportJmullinkProject4Controller(JmullinkProject4Context context, JmullinkProject4Service service)
        {
            this.service = service;
            this.context = context;
        }

        [HttpGet("/export/JmullinkProject4/micalexes/csv")]
        [HttpGet("/export/JmullinkProject4/micalexes/csv(fileName='{fileName}')")]
        public async System.Threading.Tasks.Task<FileStreamResult> ExportMicAlexesToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(await service.GetMicAlexes(), Request.Query), fileName);
        }

        [HttpGet("/export/JmullinkProject4/micalexes/excel")]
        [HttpGet("/export/JmullinkProject4/micalexes/excel(fileName='{fileName}')")]
        public async System.Threading.Tasks.Task<FileStreamResult> ExportMicAlexesToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(await service.GetMicAlexes(), Request.Query), fileName);
        }
        [HttpGet("/export/JmullinkProject4/micjoris/csv")]
        [HttpGet("/export/JmullinkProject4/micjoris/csv(fileName='{fileName}')")]
        public async System.Threading.Tasks.Task<FileStreamResult> ExportMicJorisToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(await service.GetMicJoris(), Request.Query), fileName);
        }

        [HttpGet("/export/JmullinkProject4/micjoris/excel")]
        [HttpGet("/export/JmullinkProject4/micjoris/excel(fileName='{fileName}')")]
        public async System.Threading.Tasks.Task<FileStreamResult> ExportMicJorisToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(await service.GetMicJoris(), Request.Query), fileName);
        }
        [HttpGet("/export/JmullinkProject4/mickays/csv")]
        [HttpGet("/export/JmullinkProject4/mickays/csv(fileName='{fileName}')")]
        public async System.Threading.Tasks.Task<FileStreamResult> ExportMicKaysToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(await service.GetMicKays(), Request.Query), fileName);
        }

        [HttpGet("/export/JmullinkProject4/mickays/excel")]
        [HttpGet("/export/JmullinkProject4/mickays/excel(fileName='{fileName}')")]
        public async System.Threading.Tasks.Task<FileStreamResult> ExportMicKaysToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(await service.GetMicKays(), Request.Query), fileName);
        }
    }
}
