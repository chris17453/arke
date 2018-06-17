using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace arke.Controllers {
    [ApiController]
    public class RouteController : ControllerBase {
    	public string Handler(string json){
			//args  = flattent args from json
			//type  = lookup from route
			//script= lookup from route
			shell.Run(type, script, args);
			return DateTime.Now.ToString();
        }//end funciton
	}//end class
}//end namespace
