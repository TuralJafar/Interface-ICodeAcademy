using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp21
{
    public interface ICodeAcademy
    {
        public string CodeEmail { get; set; }
        void GenerateEmail();

       


    }
}
