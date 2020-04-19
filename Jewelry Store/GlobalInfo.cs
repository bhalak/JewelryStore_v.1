using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jewelry_Store
{
  public static class GlobalInfo
    {
        public static string currentUserLevelAccess { get; set; }
        public static MainWindowForm mainWindow { get; set; }

        public static AuthorizationForm authorizationForm { get; set; }
}
}
