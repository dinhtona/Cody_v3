using Microsoft.AspNetCore.Http;

namespace ExcelWebTool.Services.DTOs
{
    public class ExcelRequestDTO
    {
        public IFormFileCollection ExcelFiles { get; set; }
    }
}
