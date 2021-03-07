using System;
using System.Collections.Generic;
using System.Text;
using 

namespace AniChara.Shared.Models
{
    public class Series
    {
        public string Title { get; set; }
        public string image_url { get; set; }
        public string Description { get; set; }
        public string Format { get; set; }
        public string source { get; set; }
        public int Episodes { get; set; }
        public int RunTime { get; set; }
        public DateTime Premiere { get; set; }
        public List<string> Tags { get; set; }
        public List<string> studios { get; set; }


    }
}
