using System.Collections.Generic;

namespace RESTfulTestful
{
    class Reddit
    {
        public RedditData data { get; set; }
    }

    class RedditData
    {
        public IList<RedditChildren> children { get; set; }
    }

    class RedditChildren
    {
        public string name { get; set; }
        public IList<string> mod_permissions { get; set; }
    }
}
