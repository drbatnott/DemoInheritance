using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    /// <summary>
    /// Base class for all media types
    /// CD
    /// Videos 
    ///     BetaMax
    ///     VHS
    /// Vinyl
    ///     45s
    ///     33 1/3 LPs 
    /// Cassettes
    /// 
    /// </summary>
    class Media
    {
        string title;
        string shortDescription;

        public Media(string t, string sD)
        {
            title = t;
            ShortDescription = sD;
        }
        public string Title
        {
            get{ return title; }
        }
    /// <summary>
    /// 
    /// shortDescription has a maximum of 10 characters
    /// </summary>
    public string ShortDescription
        {
            get { return shortDescription; }
            set {
                if (value.Length > 10)
                {
                    value = value.Substring(0, 10);
                }
                shortDescription = value;
            }
        }
}
}
