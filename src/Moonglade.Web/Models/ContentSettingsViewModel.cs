﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Moonglade.Web.Models
{
    public class ContentSettingsViewModel
    {
        [Required]
        [Display(Name = "Enable Comments")]
        public bool EnableComments { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Blocked Words")]
        public string DisharmonyWords { get; set; }

        [Required]
        [Display(Name = "Enable Word Filter")]
        public bool EnableWordFilter { get; set; }

        [Required]
        [Display(Name = "Use Friendly 404 Image")]
        public bool UseFriendlyNotFoundImage { get; set; }

        [Required]
        [Display(Name = "Post List Page Size")]
        [Range(1, 100, ErrorMessage = "Page Size can only range from 1-1024")]
        public int PostListPageSize { get; set; }
    }
}
