using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace arke.Controllers {
    [ApiController]
    public class RouteController : ControllerBase {
    	public string Handler(string json){

			string type   = String.Empty;
			string script = String.Empty;
			string args   = String.Empty;
			models.json_output o=shell.Run(type, script, args);
			string output=JsonConvert.SerializeObject(o);
			return output;
        }//end funciton
	}//end class
}//end namespace
