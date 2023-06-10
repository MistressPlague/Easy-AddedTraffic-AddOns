using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_AddedTraffic_AddOns
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [Serializable]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public partial class Settings
    {
        private SettingsWaitTime waitTimeField;

        private byte cruiseSpeedField;

        private byte spawnDistanceField;

        private string drivingStyleField;

        private bool enableUpgradeField;

        private byte upgradeChanceField;

        private bool randomizeColorField;

        private bool randomizeWheelsField;

        private bool enableNeonUpgradeField;

        private byte swapChanceField;

        private byte swapDistanceField;

        private bool notifyField;

        private bool showBlipField;

        private bool debugTextField;

        private string roadTypeField;

        private SettingsVehicleSwap[] vehicleSwapsField;

        private SettingsVehicles vehiclesField;

        private bool spawnParkedVehicleField;

        private byte maxVehicleAllowField;

        /// <remarks/>
        public SettingsWaitTime WaitTime
        {
            get
            {
                return waitTimeField;
            }
            set
            {
                waitTimeField = value;
            }
        }

        /// <remarks/>
        public byte CruiseSpeed
        {
            get
            {
                return cruiseSpeedField;
            }
            set
            {
                cruiseSpeedField = value;
            }
        }

        /// <remarks/>
        public byte SpawnDistance
        {
            get
            {
                return spawnDistanceField;
            }
            set
            {
                spawnDistanceField = value;
            }
        }

        /// <remarks/>
        public string DrivingStyle
        {
            get
            {
                return drivingStyleField;
            }
            set
            {
                drivingStyleField = value;
            }
        }

        /// <remarks/>
        public bool EnableUpgrade
        {
            get
            {
                return enableUpgradeField;
            }
            set
            {
                enableUpgradeField = value;
            }
        }

        /// <remarks/>
        public byte UpgradeChance
        {
            get
            {
                return upgradeChanceField;
            }
            set
            {
                upgradeChanceField = value;
            }
        }

        /// <remarks/>
        public bool RandomizeColor
        {
            get
            {
                return randomizeColorField;
            }
            set
            {
                randomizeColorField = value;
            }
        }

        /// <remarks/>
        public bool RandomizeWheels
        {
            get
            {
                return randomizeWheelsField;
            }
            set
            {
                randomizeWheelsField = value;
            }
        }

        /// <remarks/>
        public bool EnableNeonUpgrade
        {
            get
            {
                return enableNeonUpgradeField;
            }
            set
            {
                enableNeonUpgradeField = value;
            }
        }

        /// <remarks/>
        public byte SwapChance
        {
            get
            {
                return swapChanceField;
            }
            set
            {
                swapChanceField = value;
            }
        }

        /// <remarks/>
        public byte SwapDistance
        {
            get
            {
                return swapDistanceField;
            }
            set
            {
                swapDistanceField = value;
            }
        }

        /// <remarks/>
        public bool Notify
        {
            get
            {
                return notifyField;
            }
            set
            {
                notifyField = value;
            }
        }

        /// <remarks/>
        public bool ShowBlip
        {
            get
            {
                return showBlipField;
            }
            set
            {
                showBlipField = value;
            }
        }

        /// <remarks/>
        public bool DebugText
        {
            get
            {
                return debugTextField;
            }
            set
            {
                debugTextField = value;
            }
        }

        /// <remarks/>
        public string RoadType
        {
            get
            {
                return roadTypeField;
            }
            set
            {
                roadTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItem("VehicleSwap", IsNullable = false)]
        public SettingsVehicleSwap[] VehicleSwaps
        {
            get
            {
                return vehicleSwapsField;
            }
            set
            {
                vehicleSwapsField = value;
            }
        }

        /// <remarks/>
        public SettingsVehicles Vehicles
        {
            get
            {
                return vehiclesField;
            }
            set
            {
                vehiclesField = value;
            }
        }

        /// <remarks/>
        public bool SpawnParkedVehicle
        {
            get
            {
                return spawnParkedVehicleField;
            }
            set
            {
                spawnParkedVehicleField = value;
            }
        }

        /// <remarks/>
        public byte MaxVehicleAllow
        {
            get
            {
                return maxVehicleAllowField;
            }
            set
            {
                maxVehicleAllowField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public partial class SettingsWaitTime
    {

        private byte morningField;

        private byte afternoonField;

        private byte eveningField;

        private byte nightField;

        private byte midnightField;

        /// <remarks/>
        public byte Morning
        {
            get
            {
                return morningField;
            }
            set
            {
                morningField = value;
            }
        }

        /// <remarks/>
        public byte Afternoon
        {
            get
            {
                return afternoonField;
            }
            set
            {
                afternoonField = value;
            }
        }

        /// <remarks/>
        public byte Evening
        {
            get
            {
                return eveningField;
            }
            set
            {
                eveningField = value;
            }
        }

        /// <remarks/>
        public byte Night
        {
            get
            {
                return nightField;
            }
            set
            {
                nightField = value;
            }
        }

        /// <remarks/>
        public byte Midnight
        {
            get
            {
                return midnightField;
            }
            set
            {
                midnightField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public partial class SettingsVehicleSwap
    {

        private string oldVehicleField;

        private string newVehicleField;

        private bool enableField;

        /// <remarks/>
        public string OldVehicle
        {
            get
            {
                return oldVehicleField;
            }
            set
            {
                oldVehicleField = value;
            }
        }

        /// <remarks/>
        public string NewVehicle
        {
            get
            {
                return newVehicleField;
            }
            set
            {
                newVehicleField = value;
            }
        }

        /// <remarks/>
        public bool Enable
        {
            get
            {
                return enableField;
            }
            set
            {
                enableField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public partial class SettingsVehicles
    {

        private string[] downtownField;

        private string[] vinewoodField;

        private string[] southLosSantosField;

        private string[] portOfSouthLosSantosField;

        private string[] eastLosSantosField;

        private string[] vespucciField;

        private string[] losSantosField;

        private string[] grandSenoraDesertField;

        private string[] sanChianskiMountainRangeField;

        private string[] blaineCountyField;

        private string[] fortZancudoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItem(IsNullable = false)]
        public string[] Downtown
        {
            get
            {
                return downtownField;
            }
            set
            {
                downtownField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItem(IsNullable = false)]
        public string[] Vinewood
        {
            get
            {
                return vinewoodField;
            }
            set
            {
                vinewoodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItem(IsNullable = false)]
        public string[] SouthLosSantos
        {
            get
            {
                return southLosSantosField;
            }
            set
            {
                southLosSantosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItem(IsNullable = false)]
        public string[] PortOfSouthLosSantos
        {
            get
            {
                return portOfSouthLosSantosField;
            }
            set
            {
                portOfSouthLosSantosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItem(IsNullable = false)]
        public string[] EastLosSantos
        {
            get
            {
                return eastLosSantosField;
            }
            set
            {
                eastLosSantosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItem(IsNullable = false)]
        public string[] Vespucci
        {
            get
            {
                return vespucciField;
            }
            set
            {
                vespucciField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItem(IsNullable = false)]
        public string[] LosSantos
        {
            get
            {
                return losSantosField;
            }
            set
            {
                losSantosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItem(IsNullable = false)]
        public string[] GrandSenoraDesert
        {
            get
            {
                return grandSenoraDesertField;
            }
            set
            {
                grandSenoraDesertField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItem(IsNullable = false)]
        public string[] SanChianskiMountainRange
        {
            get
            {
                return sanChianskiMountainRangeField;
            }
            set
            {
                sanChianskiMountainRangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItem(IsNullable = false)]
        public string[] BlaineCounty
        {
            get
            {
                return blaineCountyField;
            }
            set
            {
                blaineCountyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItem(IsNullable = false)]
        public string[] FortZancudo
        {
            get
            {
                return fortZancudoField;
            }
            set
            {
                fortZancudoField = value;
            }
        }
    }
}
