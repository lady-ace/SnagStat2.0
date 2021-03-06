﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SsApi.Models.DataModels
{
    public class Team
    {
        [Required]
        public ApplicationUser User
        {
            get; set;
        }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<Game> Games
        {
            get; set;
        }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<TeamStatType> TeamStatTypes
        {
            get; set;
        }

        public virtual int Id
        {
            get; set;
        }
        public virtual string Name
        {
            get; set;
        }
        public virtual string Season
        {
            get; set;
        }
    }
}