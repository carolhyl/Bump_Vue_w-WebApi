﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace webapi.Models
{
    public partial class Member
    {
        public Member()
        {
            Carts = new HashSet<Cart>();
            Conversations = new HashSet<Conversation>();
            CouponSendＭembers = new HashSet<CouponSendＭember>();
            ExperienceEnrollments = new HashSet<ExperienceEnrollment>();
            MemberPoints = new HashSet<MemberPoint>();
            Members_Histories = new HashSet<Members_History>();
            Orders = new HashSet<Order>();
            SkillEnrollments = new HashSet<SkillEnrollment>();
            MemberTags = new HashSet<MemberTag>();
        }

        public int Id { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public int MemberLevelId { get; set; }
        public int Points { get; set; }
        public string Thumbnail { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime Birthday { get; set; }
        public string PhoneNumber { get; set; }
        public bool DMSubscribe { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastModified { get; set; }
        public bool IsConfirm { get; set; }
        public bool IsBanned { get; set; }
        public string ConfirmCode { get; set; }

        public virtual MemberLevel MemberLevel { get; set; }
        public virtual MemberLevelDetail MemberLevelDetail { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Conversation> Conversations { get; set; }
        public virtual ICollection<CouponSendＭember> CouponSendＭembers { get; set; }
        public virtual ICollection<ExperienceEnrollment> ExperienceEnrollments { get; set; }
        public virtual ICollection<MemberPoint> MemberPoints { get; set; }
        public virtual ICollection<Members_History> Members_Histories { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<SkillEnrollment> SkillEnrollments { get; set; }

        public virtual ICollection<MemberTag> MemberTags { get; set; }
    }
}