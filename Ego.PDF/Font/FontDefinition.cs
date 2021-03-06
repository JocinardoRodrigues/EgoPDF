
using System;
using System.Collections.Generic;

using Ego.PDF;
using Ego.PDF.Data;

namespace Ego.PDF.Font
{
    public class FontDefinition
    {
        public FontTypeEnum type { get; set; }
        public string name { get; set; }
        public int up { get; set; }
        public int ut { get; set; }
        public int i { get; set; }

        //file information
        public int n { get; set; }
        public int length1 { get; set; }
        public int length2 { get; set; }

        public object diff { get; set; }
        public int? diffn { get; set; }

        public string file { get; set; }

        public int size1 { get; set; }
        public int size2 { get; set; }
        public int originalsize { get; set; }

        public PHP.OrderedMap cw { get; set; }
        public Dictionary<string, int> Widths { get; set; }
        public Dictionary<string, string> desc { get; set; }

        public FontDefinition()
        {
            this.cw = new PHP.OrderedMap();
            this.Widths = new Dictionary<string, int>();
            this.desc = new Dictionary<string, string>();
        }

        public void RegisterWidths()
        {
            foreach (string par in cw.Keys)
            {
                int width = Convert.ToInt32(cw[par]);
                this.Widths[par] = width;
            }
        }
    }
}