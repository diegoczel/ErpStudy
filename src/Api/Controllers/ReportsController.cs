using Application.DTOs;
using Application.Interfaces;
using FastReport.Export.PdfSimple;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly IProdutoService _produtoService;
        private readonly IWebHostEnvironment _webHostEnv;

        public ReportsController(IProdutoService produtoService, IWebHostEnvironment webHostEnv)
        {
            _produtoService = produtoService;
            _webHostEnv = webHostEnv;
        }

        [HttpGet("{nome}")]
        public IActionResult GetReport(string nome)
        {
            var pathOfReport = Path.Combine(@"C:\dev\c#\Projects\ErpStudy\src\Api\", @$"Reports\{nome}.frx");

            var produtos = new List<ProdutoGetDTO>();
            produtos.Add(_produtoService.GetById(1).Result);
            produtos.Add(_produtoService.GetById(2).Result);
            produtos.Add(_produtoService.GetById(3).Result);
            produtos.Add(_produtoService.GetById(15).Result);

            var report = new FastReport.Report();
            report.Report.Load(pathOfReport);
            report.Dictionary.RegisterBusinessObject(produtos, "Lista Produtos", 1, true);
            report.Prepare();
            var pdf = new PDFSimpleExport();

            using var ms = new MemoryStream();
            pdf.Export(report, ms);
            ms.Flush();

            return File(ms.ToArray(), "application/pdf");
        }

        [HttpPost("{nome}")]
        public IActionResult CreateReport(string nome)
        {
            var pathOfReport = Path.Combine(@"C:\dev\c#\Projects\ErpStudy\src\Api\", @$"Reports\{nome}.frx");

            var report = new FastReport.Report();

            var produtos = new List<ProdutoGetDTO>();
            produtos.Add(_produtoService.GetById(1).Result);
            produtos.Add(_produtoService.GetById(2).Result);
            produtos.Add(_produtoService.GetById(3).Result);
            produtos.Add(_produtoService.GetById(15).Result);

            report.Dictionary.RegisterBusinessObject(produtos, "Lista Produtos", 1, true);
            report.Report.Save(pathOfReport);

            return Created(nameof(GetReport), new {nome = $"{nome}"});
        }


    }
}
