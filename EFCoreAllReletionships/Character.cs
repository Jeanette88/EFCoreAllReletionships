﻿using System.Text.Json.Serialization;

namespace EFCoreAllReletionships
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string RpgClass { get; set; } = "Knight";
        
        [JsonIgnore]
        public User User { get; set; }
        public int UserId { get; set; }
        public Weapon Weapon { get; set; }
        public int WeaponId { get; set; }

    }
}
