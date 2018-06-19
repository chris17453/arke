using System;
using System.Collections.Generic;

namespace arke.models {
    public class json_input {
        public string                    method     { get; set; }
		public string                    group      { get; set; }
		public Dictionary<string,string> arguments  { get; set; }
        public json_input() {
        }
    }
}
