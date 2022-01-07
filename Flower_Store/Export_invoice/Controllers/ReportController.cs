using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using AspNetCore.Reporting;

namespace Export_invoice.Controllers
{
    public class ReportController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IExportInvoice _exportInvoice;
        public ReportController(IWebHostEnvironment webHostEnvironment, IExportInvoice exportInvoice)
        {
            this._webHostEnvironment = webHostEnvironment;
            this._exportInvoice = exportInvoice;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> PrintAsync()
        {
            string mimtype = "";
            int extension = 1;
            var path = $"{this._webHostEnvironment.WebRootPath}\\Reports\\Report1.rdlc";
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            //parameters.Add("inv1", "welcome");
            var invoice = await _exportInvoice.GetINVOICEs();
            LocalReport localReport = new LocalReport(path);
            localReport.AddDataSource("DataSet1", invoice);
            var result = localReport.Execute(RenderType.Pdf, extension, parameters, mimtype);
            return File(result.MainStream, "application/pdf");
        }
    }
}
