using System;
using System.ComponentModel.DataAnnotations;
using EFaster.Core.Enums;

namespace EFaster.Core.Models
{
    public class Media
    {
        [StringLength(450)]
        public string Caption { get; set; }

        public int FileSize { get; set; }

        [StringLength(450)]
        public string FileName { get; set; }

        public MediaType MediaType { get; set; }
    }
}
