using System;

namespace MHG.AspNet.WebApi2.Upload.Models {
    public class FileResult {
        public string[] FileNames { get; set; }
        public string[] Names { get; set; }
        public string[] ContentTypes { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTimestamp { get; set; }
        public DateTime UpdatedTimestamp { get; set; }
    }
}