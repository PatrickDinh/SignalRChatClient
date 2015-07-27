using System.Collections.Generic;
using System.Linq;
using Nancy.ViewEngines.Razor;

namespace SignalRChatClient.App
{
    public class RazorConfig : IRazorConfiguration
    {
        public IEnumerable<string> GetAssemblyNames()
        {
            return Enumerable.Empty<string>();
        }

        public IEnumerable<string> GetDefaultNamespaces()
        {
            return Enumerable.Empty<string>();
        }

        public bool AutoIncludeModelNamespace
        {
            get { return true; }
        }
    }
}
