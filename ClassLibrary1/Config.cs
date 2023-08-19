using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public string testa = "testaa";
        public bool Debug { get; set; } = false;
    }
}
