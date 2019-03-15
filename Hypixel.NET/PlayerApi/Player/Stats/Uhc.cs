﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class Uhc
    {
        #region general stats	
        [JsonProperty("kills")]
        public long Kills { get; set; }

        [JsonProperty("score")]
        public long Score { get; set; }

        [JsonProperty("coins")]
        public long Coins { get; set; }

        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        [JsonProperty("heads_eaten")]
        public long HeadsEaten { get; set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; set; }

        [JsonProperty("equippedKit")]
        public string EquippedKit { get; set; }

        [JsonProperty("wins")]
        public long Wins { get; set; }
        #endregion

        #region solo	
        [JsonProperty("deaths_solo")]
        public long DeathsSolo { get; set; }

        [JsonProperty("wins_solo")]
        public long WinsSolo { get; set; }

        [JsonProperty("kills_solo")]
        public long KillsSolo { get; set; }

        [JsonProperty("heads_eaten_solo")]
        public long HeadsEatenSolo { get; set; }
        #endregion

        #region brawl	
        [JsonProperty("deaths_brawl")]
        public long DeathsBrawl { get; set; }

        [JsonProperty("heads_eaten_brawl")]
        public long HeadsEatenBrawl { get; set; }

        [JsonProperty("kills_brawl")]
        public long KillsBrawl { get; set; }

        [JsonProperty("wins_brawl")]
        public long WinsBrawl { get; set; }

        [JsonProperty("kills_solo brawl")]
        public long KillsSoloBrawl { get; set; }

        [JsonProperty("deaths_solo brawl")]
        public long DeathsSoloBrawl { get; set; }

        [JsonProperty("heads_eaten_solo brawl")]
        public long HeadsEatenSoloBrawl { get; set; }

        [JsonProperty("wins_solo brawl")]
        public long WinsSoloBrawl { get; set; }

        [JsonProperty("kills_duo brawl")]
        public long KillsDuoBrawl { get; set; }

        [JsonProperty("deaths_duo brawl")]
        public long DeathsDuoBrawl { get; set; }

        [JsonProperty("heads_eaten_duo brawl")]
        public long HeadsEatenDuoBrawl { get; set; }

        [JsonProperty("wins_duo brawl")]
        public long WinsDuoBrawl { get; set; }
        #endregion
    }
}