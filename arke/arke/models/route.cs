using System;
using System.Collections.Generic;

namespace arke.models {
    public class route {
		public string display_name                  { get; set; }   
		public string group                         { get; set; }
		public string method                        { get; set; }
		public string type                          { get; set; }   // python,php,perl,go,bash,ruby,webAPI
		public string target                        { get; set; }   // file name to execute
		public string target_location               { get; set; }   // path to file
        public Dictionary<string,string> arguments  { get; set; }   // arguments to pass from the ui
		public Dictionary<string,string> variables  { get; set; }   // arguments to pass to configure the script
		public bool   wait_for_script               { get; set; }   // wait for the script to complete before returning
		public int    wait_timeout                  { get; set; }   // how long to wait before terminating the call
		public bool   web_request                   { get; set; }   // is this a web request?
		public bool   active                        { get; set; }   // is this even on?
              
        public route() {
        }
    }
}