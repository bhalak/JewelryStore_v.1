using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jewelry_Store
{
  public static class GlobalInfo
    {
        public static User currentUser { get; set; }
        public static MainWindowForm mainWindow { get; set; }

        public static AuthorizationForm authorizationForm { get; set; }

        internal static List<Constituents> constituents { get; set; }
    }
}
