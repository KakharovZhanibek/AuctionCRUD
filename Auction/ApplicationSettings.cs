using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction
{
    public static class ApplicationSettings
    {
        public static readonly string CONNECTION_STRING =
            ConfigurationManager.ConnectionStrings["DefaultConnectionString"]
            .ConnectionString;
    }
}
