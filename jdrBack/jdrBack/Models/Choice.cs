﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace jdrBack.Models
{
    public partial class Choice
    {
        public int ChoiceId { get; set; }
        public int? SceneId { get; set; }
        public string ChoiceText { get; set; }
        public string ChoiceTextLiaison { get; set; }
        public int? NextSceneId { get; set; }
        public int? LifePoint { get; set; }
        public string Condition { get; set; }
        public string Rules { get; set; }
        public int? FightId { get; set; }
    }
}