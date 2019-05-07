using GroupDocs.Conversion.MVC.Products.Conversion.Config;

namespace GroupDocs.Conversion.MVC.Products.Common.Config
{
    /// <summary>
    /// Global configuration
    /// </summary>
    public class GlobalConfiguration
    {
        public ServerConfiguration Server;
        public ApplicationConfiguration Application;
        public CommonConfiguration Common;
        private readonly ConversionConfiguration Conversion;
       
        /// <summary>
        /// Get all configurations
        /// </summary>
        public GlobalConfiguration()
        {            
            Server = new ServerConfiguration();
            Application = new ApplicationConfiguration();
            Common = new CommonConfiguration();
            Conversion = new ConversionConfiguration();
        }

        public ConversionConfiguration GetConversionConfiguration() {
            return Conversion;
        }
    }
}