using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.Blocks;

namespace KeaPulss.Models.ViewModels
{
    
    public class FooterViewModel 
    {
        public MediaWithCrops LogoFooter { get; set; }
        public string Slogan { get; set; }
        public BlockListModel SoMeLinks { get; set; }
        public string Address { get; set; }
        public string AdressIdName { get; set; }
        public string OpeningHours { get; set; }
        public string OpeningHoursIdName { get; set; }
        public string Contact { get; set;}
        public string ContactIdName{ get; set;}

    }
}
