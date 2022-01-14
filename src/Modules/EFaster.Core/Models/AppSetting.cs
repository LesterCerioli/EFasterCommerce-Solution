using System;
using System.ComponentModel.DataAnnotations;

namespace EFaster.Core.Models
{
    public class AppSetting
    {
        public AppSetting(string id)
        {
            Id = id;
        }

        [StringLength(450)]
        public string Value { get; set; }

        [StringLength(450)]
        public string Module { get; set; }

        public bool IsVisibleInCommonSettingPage { get; set; }
    }
}
