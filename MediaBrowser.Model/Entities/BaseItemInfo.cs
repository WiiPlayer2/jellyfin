﻿using System;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace MediaBrowser.Model.Entities
{
    /// <summary>
    /// This is a stub class containing only basic information about an item
    /// </summary>
    [DebuggerDisplay("Name = {Name}, ID = {Id}, Type = {Type}")]
    public class BaseItemInfo
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>The id.</value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the type of the media.
        /// </summary>
        /// <value>The type of the media.</value>
        public string MediaType { get; set; }
        
        /// <summary>
        /// Gets or sets the run time ticks.
        /// </summary>
        /// <value>The run time ticks.</value>
        public long? RunTimeTicks { get; set; }

        /// <summary>
        /// Gets or sets the primary image tag.
        /// </summary>
        /// <value>The primary image tag.</value>
        public Guid? PrimaryImageTag { get; set; }

        /// <summary>
        /// Gets or sets the thumb image tag.
        /// </summary>
        /// <value>The thumb image tag.</value>
        public Guid? ThumbImageTag { get; set; }

        /// <summary>
        /// Gets or sets the thumb item identifier.
        /// </summary>
        /// <value>The thumb item identifier.</value>
        public string ThumbItemId { get; set; }

        /// <summary>
        /// Gets or sets the thumb image tag.
        /// </summary>
        /// <value>The thumb image tag.</value>
        public Guid? BackdropImageTag { get; set; }

        /// <summary>
        /// Gets or sets the thumb item identifier.
        /// </summary>
        /// <value>The thumb item identifier.</value>
        public string BackdropItemId { get; set; }

        /// <summary>
        /// Gets or sets the media version identifier.
        /// </summary>
        /// <value>The media version identifier.</value>
        public string MediaSourceId { get; set; }
        
        /// <summary>
        /// Gets a value indicating whether this instance has primary image.
        /// </summary>
        /// <value><c>true</c> if this instance has primary image; otherwise, <c>false</c>.</value>
        [IgnoreDataMember]
        public bool HasPrimaryImage
        {
            get { return PrimaryImageTag.HasValue; }
        }
    }
}
