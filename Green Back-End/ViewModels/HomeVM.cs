using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Green_Back_End.Models;

namespace Green_Back_End.ViewModels
{
    public class HomeVM
    {
        public List<Slider> sliders { get; set; }
        public List<Green_Back_End.Models.Service> Services { get; set; }
    }
}
