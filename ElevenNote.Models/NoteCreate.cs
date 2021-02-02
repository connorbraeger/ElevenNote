﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ElevenNote.Models
{
    public class NoteCreate
    {
        [Required]
        [MinLength(2, ErrorMessage ="Please enter at least 2 characters.")]
        [MaxLength(ErrorMessage ="There are too many characters in this field.")]
        public string Title { get; set; }
        [MaxLength(8000)]
        public string Content { get; set; }

        [DefaultValue(1)]
        public int CategoryId { get; set; } = 1;
    }
}