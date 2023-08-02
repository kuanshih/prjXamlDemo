using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMauiDemo.model
{
    public class CToDo
    {
        public string Todo { get; set; }
        public string date { get; set; }
        public int code { get; set; }
        public override string ToString()
        {
            return Todo;
        }
    }
}
