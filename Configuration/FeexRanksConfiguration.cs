using System.Collections.Generic;
using Freenex.FeexRanks.Database;
using Rocket.API;

namespace Freenex.FeexRanks.Configuration
{
    public class FeexRanksConfiguration : IRocketPluginConfiguration
    {
        public bool EnableLevelUpNotification;
        public bool EnableLevelUpNotificationGlobal;
        public bool EnableRankNotificationOnJoin;
        public bool EnableRankNotificationOnJoinGlobal;
        public bool EnableRankNotificationOnLeaveGlobal;
        public string NotificationColor;
        public string NotificationColorGlobal;
        public string NotificationColorJoinLeaveGlobal;
        public DatabaseConfig FeexRanksDatabaseConfig;
        public List<Event> Events;
        public List<Level> Level;

        public void LoadDefaults()
        {
            EnableLevelUpNotification = false;
            EnableLevelUpNotificationGlobal = true;
            EnableRankNotificationOnJoin = true;
            EnableRankNotificationOnJoinGlobal = false;
            EnableRankNotificationOnLeaveGlobal = false;
            NotificationColor = "Green";
            NotificationColorGlobal = "Gray";
            NotificationColorJoinLeaveGlobal = "Green";

            FeexRanksDatabaseConfig = new DatabaseConfig
            {
                DatabaseAddress = "127.0.0.1",
                DatabaseUsername = "unturned",
                DatabasePassword = "password",
                DatabaseName = "unturned",
                DatabaseTableName = "ranks",
                DatabasePort = 3306
            };

            Events = new List<Event>
            {
                new Event {EventName = "KILLS_ZOMBIES_NORMAL", Notify = false, Points = 10},
                new Event {EventName = "KILLS_ZOMBIES_MEGA", Notify = true, Points = 50},
                new Event {EventName = "KILLS_PLAYERS", Notify = true, Points = 60}
            };

            Level = new List<Level>
            {
                new Level {Points = 0, Name = "Pig"},
                new Level
                {
                    Points = 100, Name = "Small Zombie", KitUconomyReward = true, UconomyNotify = true
                },
                new Level {Points = 200, Name = "Zombie", KitItemReward = true, KitItemNotify = true, KitName = "Zombie"},
                new Level
                {
                    Points = 500, Name = "Giant Zombie", KitItemReward = true, KitItemNotify = true, KitName = "Giant Zombie",
                    PermissionGroupReward = true, PermissionGroupNotify = true, PermissionGroupName = "VIP",
                    KitUconomyReward = true, UconomyNotify = false
                }
            };
        }
    }
}
