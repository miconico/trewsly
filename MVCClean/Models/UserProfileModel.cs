// <copyright file="UserProfileModel.cs" company="trewsly">Copyright (c) Sprocket Enterprises. All rights reserved.</copyright>
// <author>auto gen MS</author>
namespace MVCClean.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    /// <summary>
    /// build up the initial model compatriots
    /// </summary>
    public class UserProfileModel
    {
        /// <summary>
        /// Gets or sets trewsly id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets handle
        /// </summary>
        public long Handle { get; set; }

        /// <summary>
        /// Gets or sets whats your angle
        /// </summary>
        public string BackGround { get; set; }

        /// <summary>
        /// Gets or sets What type of media - print web books politics
        /// </summary>
        public long Media { get; set; }

        /// <summary>
        /// Gets or sets score as a means of tracking whats been contributed to the community and try to give a weighting to their contributions
        /// </summary>
        public long Score { get; set; }

        /// <summary>
        /// Gets or sets what makes them tick - what do you wish for
        /// </summary>
        public string GetMe { get; set; }

        /// <summary>
        /// Gets or sets whats the first step to make things better - always stay positive 
        /// </summary>
        public string FirstStep { get; set; }

        /// <summary>
        /// Gets or sets is there another user or media entity site that is worth looking at
        /// </summary>
        public long OneToWatch { get; set; }

        /// <summary>
        /// Gets or sets what gets you - might be too negative
        /// </summary>
        public long PetHate { get; set; }
    }
}