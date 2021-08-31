using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreWebApi.Model
{
    public class PushEvent
    {
        public string @event { get; set; }
        public Page page { get; set; }
        public User user { get; set; }
    }

    public class Page
    {
        public PageInfo pageInfo { get; set; }
        public Category category { get; set; }
        public Attributes attributes { get; set; }
    }

    public class PageInfo
    {
        public string pageName { get; set; }
        public string appID { get; set; }
        public string buildDetails { get; set; }
        public string libDetails { get; set; }
    }

    public class Category {
        public string primaryCategory { get; set; }
        public string subCategory1 { get; set; }
    }

    public class Attributes { 
        public string country { get; set; }
        public string language { get; set; }
        public string platform { get; set; }
    }

    public class User
    {
        public UserInfo userInfo { get; set; }
    }

    public class UserInfo {
        public string userStatus { get; set; }
        public string segment { get; set; }
        public string loginType { get; set; }
        public string tandemID { get; set; }
    }
}
