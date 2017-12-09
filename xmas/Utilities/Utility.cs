using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using xmas.Models;
namespace xmas.Utilities
{
    public class Utility
    {
        public static int CheckIfUserExist(string username, string password)
        {
            int result;
            result = 1;
            return result;
        }
        public static IList<GiftsModel> GetGifts(string user)
        {
            DataSet ds;
            //hier even de lists fetchen 
            IList<GiftsModel> x = null;
            return x;
        }
        public static int AddGift(string User, string product, string url)
        {
            int result;

            result = 1;

            return result;
        }
    }
}