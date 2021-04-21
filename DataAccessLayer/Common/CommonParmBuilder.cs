using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DataAccessLayer.Common
{
    public class CommonParmBuilder
    {
        public CommonParmBuilder()
        {
        }

        /// <summary>
        /// To Get Parameter Having @StoreID,@PortalID
        /// </summary>
        /// <param name="aspxCommonObj"></param>
        /// <returns></returns>
        public static List<KeyValuePair<string, object>> GetParamU(CommonInfo commonObj)
        {
            List<KeyValuePair<string, object>> ParaMeter = new List<KeyValuePair<string, object>>();
            ParaMeter.Add(new KeyValuePair<string, object>("@userName", commonObj.userName));
            return ParaMeter;
        }
        public static List<KeyValuePair<string, object>> GetParam()
        {
            List<KeyValuePair<string, object>> ParaMeter = new List<KeyValuePair<string, object>>();
            ParaMeter.Add(new KeyValuePair<string, object>("@isActive", 1));
            return ParaMeter;
        }
        public static List<KeyValuePair<string, object>> GetParamAD()
        {
            List<KeyValuePair<string, object>> ParaMeter = new List<KeyValuePair<string, object>>();
            ParaMeter.Add(new KeyValuePair<string, object>("@isActive", 1));
            ParaMeter.Add(new KeyValuePair<string, object>("@isDeleted", 0));
            return ParaMeter;
        }

    }
}
