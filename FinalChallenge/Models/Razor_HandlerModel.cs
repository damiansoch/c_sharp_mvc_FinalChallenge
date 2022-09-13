using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalChallenge.Models
{
    public class Razor_HandlerModel
    {
        public string Message { get; set; }
        public void OnGet()
        {
            Message = "Get used";
        }
        public void OnPost()
        {
            Message = "Post used";
        }
    }
}
