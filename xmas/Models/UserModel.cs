using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace xmas.Models
{
    public class UserModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int IsActive { get; set; }
        public IList<GiftsModel> gifts {get; set;} 

    }
}