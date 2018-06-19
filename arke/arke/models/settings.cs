using System;
using System.Collections.Generic;

namespace arke.models {
	public class settings : JsonFile<settings>{
		List<route> routes { get; set;  }
        public settings() {
        }
    }
}
