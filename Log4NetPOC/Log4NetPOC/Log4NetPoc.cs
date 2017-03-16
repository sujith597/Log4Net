using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Core;
using log4net.Config;

namespace Log4NetProofOfConcept
{
    class Log4NetPoc
    {
        private static readonly ILog _logger = LogManager.GetLogger(typeof(Log4NetPoc));

        static Log4NetPoc() {
            //BasicConfigurator.Configure(); // Which will go with default configuration i.e console output
            XmlConfigurator.Configure();
        }
        static void Main(string[] args)
        {          

            _logger.Debug("This is Debug message");
            _logger.Info("This is Info message");
            _logger.Warn("This is Warning message");
            _logger.Error("This is Error message");
            _logger.Fatal("This is Fatal message");

            Console.ReadKey();
        }
    }
}
