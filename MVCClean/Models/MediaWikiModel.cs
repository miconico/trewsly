// <copyright file="MediaWikiModel.cs" company="trewsly">Copyright (c) Trewsly. All rights reserved.</copyright>
// <author>Mark Gavin</author>
namespace MVCClean.Models 
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    /// <summary>
    /// This class stores the basic information about a media outlet be it print online magazine paper
    /// </summary>
    public class MediaWikiModel
    {
        /// <summary>
        /// Gets or sets Unique Id for Media Outloet 
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the unique Id for owner link to other media items they own
        /// </summary>
        public long OwnerId { get; set; }

        /// <summary>
        /// Gets or sets overview of the outlet what it does and some headline bits about it
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// Gets or sets what media areas it has outlets in e.g. web, mobile, print, magazine, books, advertising
        /// </summary>
        public long[] MediaTypes { get; set; }

        /// <summary>
        /// Gets or sets how much money does it take in - just turnover 
        /// </summary>
        public decimal TurnOver { get; set; }

        /// <summary>
        /// Gets or sets how did it come about - a short history of when/where it originated types of mergers or angles why it was created
        /// </summary>
        public string Origin { get; set; }

        /// <summary>
        /// Gets or sets does it have an agenda that is obvious subtle or opaque
        /// </summary>
        public string Agenda { get; set; }

        /// <summary>
        /// Gets or sets this is the look up tag for the outlet which gets the lists of tags that have been applied to it
        /// </summary>
        public long TagId { get; set; }

        /// <summary>
        /// Gets or sets this is the look up trewsly id for the rating it has gotten
        /// </summary>
        public long TrewslyRatingId { get; set; }
    }
}