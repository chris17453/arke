using System;
using System.Diagnostics;
using System.IO;

namespace arke {
    public static class shell {
		/// <summary>
        /// execute a script on a local machine
        /// </summary>
        /// <returns>The run.</returns>
        /// <param name="type">Type.</param>
        /// <param name="script">Script.</param>
        /// <param name="args">Arguments.</param>
		public static models.json_output Run(string type,string script, string args) {
            ProcessStartInfo start       = new ProcessStartInfo();
			string engine = "";
			switch(type) {
				case "bash"  : engine = "bash";   break;
				case "go"    : engine = "go";     break;
				case "java"  : engine = "java";   break;
				case "php"   : engine = "php";    break;
				case "python": engine = "python"; break;
				default: break;
			}
			start.FileName               = engine;
            start.Arguments              = string.Format("\"{0}\" \"{1}\"", script, args);
            start.UseShellExecute        = false;
            start.CreateNoWindow         = true; 
            start.RedirectStandardOutput = true;
            start.RedirectStandardError  = true; 
            using (Process process = Process.Start(start)) {
				process.WaitForExit();
                using (StreamReader reader = process.StandardOutput) {
                    string stderr = process.StandardError.ReadToEnd(); 
                    string result = reader.ReadToEnd();
					models.json_output output = new models.json_output();
					output.output = result;
					output.exit_code = process.ExitCode;
					return output;
                }
            }
        }//end function
    }//end class
}//end namespace
