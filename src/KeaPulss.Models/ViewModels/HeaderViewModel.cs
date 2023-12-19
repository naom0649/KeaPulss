using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models;


namespace KeaPulss.Models.ViewModels
{
    public class HeaderViewModel
    {

        public MediaWithCrops? Logo { get; set; }
        public string? NewsUrl { get; set; }
        public string? NewsLinkTitle { get; set; }
        public string? EventUrl { get; set; }
        public string? EventTitle { get; set; }
        public string? StudielivUrl { get; set; }
        public string? StudielivTitle { get; set; }
        public string? LoginUrl {  get; set; }

    }
}
