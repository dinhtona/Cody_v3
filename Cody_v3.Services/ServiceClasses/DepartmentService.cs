using ExcelWebTool.Repositories.Entities;
using ExcelWebTool.Repositories.Interfaces;
using ExcelWebTool.Services.Generics;
using ExcelWebTool.Services.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelWebTool.Services.ServiceClasses
{
    public  class DepartmentService : GenericService<Department>, IDepartmentService
    {
        public DepartmentService(IGenericRepository<Department> repository) : base(repository)
        {
        }
    }
}
