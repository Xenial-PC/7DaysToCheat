namespace C7D2C.Classes
{
    public class RecoilValues
    {
        public string Gun { get; set; }
        public float KickDegreesHorizontalMax { get; set; } = 0;
        public float KickDegreesHorizontalMin { get; set; } = 0;
        public float KickDegreesVerticalMax { get; set; } = 0;
        public float KickDegreesVerticalMin { get; set; } = 0;
        public float SpreadDegreesHorizontal { get; set; } = 0;
        public float SpreadDegreesVertical { get; set; } = 0;
    }

    public class WeaponOptions
    {
        public string Gun { get; set; }
        public bool IsNoSpreadEnabled { get; set; }
        public bool IsNoRecoilEnabled { get; set; }
        public bool IsInstaKillEnabled { get; set; }
        public bool IsInsaneFireRateEnabled { get; set; }
        public bool IsFastFireRateEnabled { get; set; }
        public bool IsUnlimitedAmmoEnabled { get; set; }
        public bool IsMaxDurabilityEnabled { get; set; }
        public bool IsMaxRangeEnabled { get; set; }
        public bool IsMaxMagSizeEnabled { get; set; }
    }
}
