﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace webapi.Models
{
    public partial class DM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string MailContent { get; set; }
        public string DMFile { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? SendingTime { get; set; }
    }
}