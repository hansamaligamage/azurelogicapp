using System.ComponentModel;

namespace TweetAnalysis
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tweet")]
    public partial class Tweet
    {
        public int Id { get; set; }
        [DisplayName("Tweet")]
        [Key]
        [Column("Tweet", Order = 0)]
        public string Tweet1 { get; set; }

        [DisplayName("Tweet by")]
        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string TweetUser { get; set; }

        [DisplayName("DateTime")]
        [Key]
        [Column(Order = 2)]
        public DateTime CreatedDateTime { get; set; }

        [StringLength(100)]
        public string User { get; set; }

        [DisplayName("Profile")]
        public string ProfileImageUrl { get; set; }

        [DisplayName("Attachment")]

        public string AttachmentImgUrl { get; set; }

        [DisplayName("Tweet Id")]
        [StringLength(100)]
        public string TweetId { get; set; }

        public bool? Winner { get; set; }
    }
}
