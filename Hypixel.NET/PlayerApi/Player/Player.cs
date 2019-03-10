﻿using System.Collections.Generic;
using Hypixel.NET.Player.Stats;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player
{
    public class Player
    {

        /// <summary>
        /// The tiered achievements that require x wins or x coins to progress
        /// </summary>
        [JsonProperty("achievements")]
        public Dictionary<string, long> Achievements { get; set; }

        /// <summary>
        /// General onetime unlock achievements
        /// </summary>
        [JsonProperty("achievementsOneTime")]
        public List<string> AchievementsOneTime { get; set; }

        /// <summary>
        /// The display name of the player
        /// </summary>
        [JsonProperty("displayname")]
        public string Displayname { get; set; }


        /// <summary>
        /// The First time the player logged into Hypixel
        /// </summary>
        [JsonProperty("firstLogin")]
        public long FirstLogin { get; set; }

        /// <summary>
        /// The last time the player logged into Hypixel
        /// </summary>
        [JsonProperty("lastLogin")]
        public long LastLogin { get; set; }

        /// <summary>
        /// The players total xp on the server
        /// </summary>
        [JsonProperty("networkExp")]
        public long NetworkExp { get; set; }

        [JsonProperty("settings")]
        public Settings.Settings Settings { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        [JsonProperty("timePlaying")]
        public long TimePlaying { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("karma")]
        public long Karma { get; set; }

        [JsonProperty("vanityTokens")]
        public long VanityTokens { get; set; }

        [JsonProperty("petConsumables")]
        public Dictionary<string, long> PetConsumables { get; set; }

        [JsonProperty("vanityMeta")]
        public VanityMeta.VanityMeta VanityMeta { get; set; }

        [JsonProperty("parkourCompletions")]
        public Dictionary<string, List<ParkourCompletion.ParkourCompletions>> ParkourCompletions { get; set; }

        [JsonProperty("totalRewards")]
        public long TotalRewards { get; set; }

        [JsonProperty("totalDailyRewards")]
        public long TotalDailyRewards { get; set; }

        [JsonProperty("rewardStreak")]
        public long RewardStreak { get; set; }

        [JsonProperty("rewardScore")]
        public long RewardScore { get; set; }

        [JsonProperty("rewardHighScore")]
        public long RewardHighScore { get; set; }

        [JsonProperty("currentPet")]
        public string CurrentPet { get; set; }

        [JsonProperty("giftingMeta")]
        public GiftingMeta.GiftingMeta GiftingMeta { get; set; }

        [JsonProperty("lastLogout")]
        public long LastLogout { get; set; }

        [JsonProperty("rankPlusColor")]
        public string RankPlusColor { get; set; }

        [JsonProperty("voting")]
        public Dictionary<string, long> Voting { get; set; }

        [JsonProperty("achievementTracking")]
        public List<string> AchievementTracking { get; set; }

    }
}