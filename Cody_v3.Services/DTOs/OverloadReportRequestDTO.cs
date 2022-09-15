﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelWebTool.Services.DTOs
{
    public class OverloadReportRequestDTO
    {
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public Guid? DepartmentId { get; set; }
    }
}
