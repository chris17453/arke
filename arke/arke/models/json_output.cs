using System;

namespace arke.models {
	public class json_output {
		public int     exit_code { get; set;  }  //shell exit code
		public string  output    { get; set;  }  //stdout of target
        public json_output() {
        }
    }
}