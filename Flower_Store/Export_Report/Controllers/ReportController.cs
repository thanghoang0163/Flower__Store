using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using AspNetCore.Reporting;

namespace Export_Report.Controllers
{
    public class ReportController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ICustomerRepository _customerRepository;

        public ReportController(IWebHostEnvironment webHostEnvironment, ICustomerRepository customerRepository)
        {
            this._webHostEnvironment = webHostEnvironment;
            this._customerRepository = customerRepository;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Print()
        {
            string mimtype = "";
            int extension = 1;
            var path = $"{this._webHostEnvironment.WebRootPath}\\Reports\\Report1.rdlc";
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            //parameters.Add("customer", "welcome to Flower Store");
            //Get customer from customer table
            var customer = await _customerRepository.GetCUSTOMERs();
            LocalReport localReport = new LocalReport(path);
            localReport.AddDataSource("DataSet1", customer);
            var result = localReport.Execute(RenderType.Pdf, extension, parameters, mimtype);
            return File(result.MainStream, "application/pdf");
        }
    }
}
