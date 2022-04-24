using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteUpdate.Models;
using TesteUpdate.Models.ViewModels;

namespace TesteUpdate.Models.ViewModels
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}