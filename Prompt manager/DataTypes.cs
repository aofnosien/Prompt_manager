using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prompt_manager
{
    public enum NAI_type
    {
        NAI,
        WebUI,
    }

    public class TagData
    {
        public string tagName = "";
        public double positive = 0;
        public double negative = 0;
        public bool disabled = false;
    }
}
