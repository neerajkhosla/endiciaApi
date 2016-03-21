using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSI.Utils.Shipping.Endicia.Interfaces;

namespace Endicia.Api
{
    public class SimpleLogger : ILogger
    {
        public void Debug(string message)
        {
            string filePath = @"F:\Transfer_20150830\Study\endicia-nopcommerce\endiciaAPI\endiciaApiSample\Endicia.Api\IDGLog.txt";
            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                streamWriter.WriteLine(DateTime.Now.ToString() + ":" +  message);
                streamWriter.Close();
            }
        }
    }
}
