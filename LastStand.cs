using System;
using GTA;
using GTA.Native;
using System.Windows.Forms;

public class LastStand : Script
{
    private bool inLastStand = false;
    private bool canTrigger = true;
    private int originalHealth;
    private int originalArmor;
    private int lastStandStartTime;
    private int cooldownEndTime;

    private int triggerHealth = 110;
    private int boostedHealth = 500;
    private int boostedArmor = 100;
    private int lastStandDuration = 20000; // 20 seconds
    private int lastStandCooldown = 60000; // 60 seconds
    private bool notificationEnabled = true;
    private bool minigunEnabled = true;

    public LastStand()
    {
        LoadSettings();
        Tick += OnTick;
        Interval = 100;
    }

    private void LoadSettings()
    {
        string iniPath = "scripts/LastStand.ini";
        ScriptSettings settings = ScriptSettings.Load(iniPath);

        triggerHealth = settings.GetValue("General", "TriggerHealth", 110);
        boostedHealth = settings.GetValue("General", "BoostedHealth", 500);
        boostedArmor = settings.GetValue("General", "BoostedArmor", 100);
        lastStandDuration = settings.GetValue("General", "Duration", 20000);
        lastStandCooldown = settings.GetValue("General", "Cooldown", 60000);
        notificationEnabled = settings.GetValue("General", "EnableNotifications", true);
        minigunEnabled = settings.GetValue("General", "GiveMinigun", true);
    }

    private void OnTick(object sender, EventArgs e)
    {
        Ped player = Game.Player.Character;

        if (!player.IsAlive || player.IsInjured)
        {
            inLastStand = false;
            return;
        }

        if (!inLastStand && canTrigger && player.Health <= triggerHealth)
        {
            ActivateLastStand(player);
        }

        if (inLastStand)
        {
            int remaining = (lastStandStartTime + lastStandDuration - Game.GameTime) / 1000;
            if (remaining >= 0)
                GTA.UI.Screen.ShowSubtitle("~y~Last Stand: ~w~" + remaining + "s");

            if (Game.GameTime - lastStandStartTime >= lastStandDuration)
            {
                EndLastStand(player);
            }
        }

        if (!canTrigger && Game.GameTime >= cooldownEndTime)
        {
            canTrigger = true;
            if (notificationEnabled)
                GTA.UI.Notification.PostTicker("~g~Last Stand Ready!", true);
        }
    }

    private void ActivateLastStand(Ped player)
    {
        inLastStand = true;
        canTrigger = false;
        lastStandStartTime = Game.GameTime;
        cooldownEndTime = Game.GameTime + lastStandCooldown;

        originalHealth = player.Health;
        originalArmor = player.Armor;

        player.Health = boostedHealth;
        player.Armor = boostedArmor;

        if (minigunEnabled)
        {
            Weapon minigun = player.Weapons.Give(WeaponHash.Minigun, 9999, true, true);
            minigun.Ammo = 9999;
        }

        // 🔊 Play Menyoo-like sound effect
        Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "SELECT", "HUD_FRONTEND_DEFAULT_SOUNDSET", 0);

        if (notificationEnabled)
            GTA.UI.Notification.PostTicker("~y~Last Stand Activated!", true);
    }

    private void EndLastStand(Ped player)
    {
        inLastStand = false;
        player.Health = originalHealth;
        player.Armor = originalArmor;

        if (minigunEnabled)
            player.Weapons.Remove(WeaponHash.Minigun);

        if (notificationEnabled)
            GTA.UI.Notification.PostTicker("~w~Last Stand Ended.", true);
    }
}
