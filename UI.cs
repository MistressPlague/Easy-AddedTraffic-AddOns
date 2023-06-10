using CodeWalker.GameFiles;

using Microsoft.Win32;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Xml;
using System.Xml.Serialization;

namespace Easy_AddedTraffic_AddOns
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }

        private void UI_Load(object sender, EventArgs e)
        {
            var baseKey32 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);

            var steamPathValue = baseKey32.OpenSubKey(@"Software\Rockstar Games\GTAV")?.GetValue("InstallFolderSteam") as string;
            var retailPathValue = baseKey32.OpenSubKey(@"Software\Rockstar Games\Grand Theft Auto V")?.GetValue("InstallFolder") as string;
            var oivPathValue = Registry.CurrentUser.OpenSubKey(@"Software\NewTechnologyStudio\OpenIV.exe\BrowseForFolder")?.GetValue("game_path_Five_pc") as string;

            if (steamPathValue?.EndsWith("\\GTAV") == true)
            {
                steamPathValue = steamPathValue.Substring(0, steamPathValue.LastIndexOf("\\GTAV"));
            }

            if (Directory.Exists(steamPathValue) && File.Exists(steamPathValue + "\\GTA5.exe"))
            {
                PathToGTAVTextBox.Text = steamPathValue;
            }
            else if (Directory.Exists(retailPathValue) && File.Exists(retailPathValue + "\\GTA5.exe"))
            {
                PathToGTAVTextBox.Text = retailPathValue;
            }
            else if (Directory.Exists(oivPathValue) && File.Exists(oivPathValue + "\\GTA5.exe"))
            {
                PathToGTAVTextBox.Text = oivPathValue;
            }

            RefreshAddOnsButton.Select();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            using var popup = new FolderBrowserDialog();

            if (popup.ShowDialog() == DialogResult.OK)
            {
                PathToGTAVTextBox.Text = popup.SelectedPath;
            }
        }

        private void RefreshAddOnsButton_Click(object sender, EventArgs e)
        {
            // Check
            if (!File.Exists($"{PathToGTAVTextBox.Text}\\scripts\\AddedTraffic.xml"))
            {
                MessageBox.Show($"AddedTraffic.xml Does Not Exist At {PathToGTAVTextBox.Text}\\scripts\\AddedTraffic.xml");
                return;
            }

            // Back Up Prev
            File.Copy($"{PathToGTAVTextBox.Text}\\scripts\\AddedTraffic.xml", $"{PathToGTAVTextBox.Text}\\scripts\\AddedTraffic_Backup{DateTime.Now:dd-MM-yyyy hh-mm-ss tt}.xml");

            // Get Config & Load
            var xml = File.ReadAllText($"{PathToGTAVTextBox.Text}\\scripts\\AddedTraffic.xml").DeserializeXml<Settings>();

            var AllExistingCars = new List<string>(); // I know this is lazy as fuck, no booli
            AllExistingCars.AddRange(xml.Vehicles.Downtown);
            AllExistingCars.AddRange(xml.Vehicles.Vinewood);
            AllExistingCars.AddRange(xml.Vehicles.SouthLosSantos);
            AllExistingCars.AddRange(xml.Vehicles.PortOfSouthLosSantos);
            AllExistingCars.AddRange(xml.Vehicles.EastLosSantos);
            AllExistingCars.AddRange(xml.Vehicles.Vespucci);
            AllExistingCars.AddRange(xml.Vehicles.LosSantos);
            AllExistingCars.AddRange(xml.Vehicles.GrandSenoraDesert);
            AllExistingCars.AddRange(xml.Vehicles.SanChianskiMountainRange);
            AllExistingCars.AddRange(xml.Vehicles.BlaineCounty);
            AllExistingCars.AddRange(xml.Vehicles.FortZancudo);

            // Get All Add-On Cars Not In Config
            GTA5Keys.LoadFromPath(PathToGTAVTextBox.Text);

            var RpfMan = new RpfManager();
            RpfMan.EnableMods = true;
            RpfMan.Init(PathToGTAVTextBox.Text, (a) => {}, (a) => {});

            var AllAddOns = RpfMan.ModEntryDict.Where(i => i.Key.Contains("dlcpacks") && i.Key.EndsWith(".yft") && !i.Key.EndsWith("_hi.yft")).DistinctBy(o => Path.GetFileNameWithoutExtension(o.Key)).ToArray(); // cursed

            var ToAdd = AllAddOns.Where(o => !AllExistingCars.Contains(Path.GetFileNameWithoutExtension(o.Key).ToLower()));

            foreach (var add in ToAdd)
            {
                if (Keyboard.IsKeyDown(Key.Escape))
                {
                    continue;
                }

                using var popup = new CarPopup(Path.GetFileNameWithoutExtension(add.Key).ToLower(), Path.GetFileName(Path.GetDirectoryName(add.Value.File.GetPhysicalFilePath())), new []
                {
                    "Downtown",
                    "Vinewood",
                    "SouthLosSantos",
                    "PortOfSouthLosSantos",
                    "EastLosSantos",
                    "Vespucci",
                    "LosSantos",
                    "GrandSenoraDesert",
                    "SanChianskiMountainRange",
                    "BlaineCounty",
                    "FortZancudo"
                });

                if (popup.ShowDialog() == DialogResult.OK)
                {
                    foreach (var state in popup.SelectedLocations)
                    {
                        switch (state)
                        {
                            case "Downtown":
                                xml.Vehicles.Downtown = xml.Vehicles.Downtown.Add(Path.GetFileNameWithoutExtension(add.Key).ToLower());
                                break;
                            case "Vinewood":
                                xml.Vehicles.Vinewood = xml.Vehicles.Vinewood.Add(Path.GetFileNameWithoutExtension(add.Key).ToLower());
                                break;
                            case "SouthLosSantos":
                                xml.Vehicles.SouthLosSantos = xml.Vehicles.SouthLosSantos.Add(Path.GetFileNameWithoutExtension(add.Key).ToLower());
                                break;
                            case "PortOfSouthLosSantos":
                                xml.Vehicles.PortOfSouthLosSantos = xml.Vehicles.PortOfSouthLosSantos.Add(Path.GetFileNameWithoutExtension(add.Key).ToLower());
                                break;
                            case "EastLosSantos":
                                xml.Vehicles.EastLosSantos = xml.Vehicles.EastLosSantos.Add(Path.GetFileNameWithoutExtension(add.Key).ToLower());
                                break;
                            case "Vespucci":
                                xml.Vehicles.Vespucci = xml.Vehicles.Vespucci.Add(Path.GetFileNameWithoutExtension(add.Key).ToLower());
                                break;
                            case "LosSantos":
                                xml.Vehicles.LosSantos = xml.Vehicles.LosSantos.Add(Path.GetFileNameWithoutExtension(add.Key).ToLower());
                                break;
                            case "GrandSenoraDesert":
                                xml.Vehicles.GrandSenoraDesert = xml.Vehicles.GrandSenoraDesert.Add(Path.GetFileNameWithoutExtension(add.Key).ToLower());
                                break;
                            case "SanChianskiMountainRange":
                                xml.Vehicles.SanChianskiMountainRange = xml.Vehicles.SanChianskiMountainRange.Add(Path.GetFileNameWithoutExtension(add.Key).ToLower());
                                break;
                            case "BlaineCounty":
                                xml.Vehicles.BlaineCounty = xml.Vehicles.BlaineCounty.Add(Path.GetFileNameWithoutExtension(add.Key).ToLower());
                                break;
                            case "FortZancudo":
                                xml.Vehicles.FortZancudo = xml.Vehicles.FortZancudo.Add(Path.GetFileNameWithoutExtension(add.Key).ToLower());
                                break;
                        }
                    }
                }
            }

            File.WriteAllText($"{PathToGTAVTextBox.Text}\\scripts\\AddedTraffic.xml", xml.SerializeXml());

            RpfMan = null;
        }

        private void AddByModelNameButton_Click(object sender, EventArgs e)
        {
            // Check
            if (!File.Exists($"{PathToGTAVTextBox.Text}\\scripts\\AddedTraffic.xml"))
            {
                MessageBox.Show($"AddedTraffic.xml Does Not Exist At {PathToGTAVTextBox.Text}\\scripts\\AddedTraffic.xml");
                return;
            }

            // Back Up Prev
            File.Copy($"{PathToGTAVTextBox.Text}\\scripts\\AddedTraffic.xml", $"{PathToGTAVTextBox.Text}\\scripts\\AddedTraffic_Backup{DateTime.Now:dd-MM-yyyy hh-mm-ss tt}.xml");

            // Get Config & Load
            var xml = File.ReadAllText($"{PathToGTAVTextBox.Text}\\scripts\\AddedTraffic.xml").DeserializeXml<Settings>();

            using var popup = new CarPopup(ModelNameTextBox.Text, "Custom", new[]
                {
                    "Downtown",
                    "Vinewood",
                    "SouthLosSantos",
                    "PortOfSouthLosSantos",
                    "EastLosSantos",
                    "Vespucci",
                    "LosSantos",
                    "GrandSenoraDesert",
                    "SanChianskiMountainRange",
                    "BlaineCounty",
                    "FortZancudo"
                });

            if (popup.ShowDialog() == DialogResult.OK)
            {
                foreach (var state in popup.SelectedLocations)
                {
                    switch (state)
                    {
                        case "Downtown":
                            xml.Vehicles.Downtown = xml.Vehicles.Downtown.Add(ModelNameTextBox.Text);
                            break;
                        case "Vinewood":
                            xml.Vehicles.Vinewood = xml.Vehicles.Vinewood.Add(ModelNameTextBox.Text);
                            break;
                        case "SouthLosSantos":
                            xml.Vehicles.SouthLosSantos = xml.Vehicles.SouthLosSantos.Add(ModelNameTextBox.Text);
                            break;
                        case "PortOfSouthLosSantos":
                            xml.Vehicles.PortOfSouthLosSantos = xml.Vehicles.PortOfSouthLosSantos.Add(ModelNameTextBox.Text);
                            break;
                        case "EastLosSantos":
                            xml.Vehicles.EastLosSantos = xml.Vehicles.EastLosSantos.Add(ModelNameTextBox.Text);
                            break;
                        case "Vespucci":
                            xml.Vehicles.Vespucci = xml.Vehicles.Vespucci.Add(ModelNameTextBox.Text);
                            break;
                        case "LosSantos":
                            xml.Vehicles.LosSantos = xml.Vehicles.LosSantos.Add(ModelNameTextBox.Text);
                            break;
                        case "GrandSenoraDesert":
                            xml.Vehicles.GrandSenoraDesert = xml.Vehicles.GrandSenoraDesert.Add(ModelNameTextBox.Text);
                            break;
                        case "SanChianskiMountainRange":
                            xml.Vehicles.SanChianskiMountainRange = xml.Vehicles.SanChianskiMountainRange.Add(ModelNameTextBox.Text);
                            break;
                        case "BlaineCounty":
                            xml.Vehicles.BlaineCounty = xml.Vehicles.BlaineCounty.Add(ModelNameTextBox.Text);
                            break;
                        case "FortZancudo":
                            xml.Vehicles.FortZancudo = xml.Vehicles.FortZancudo.Add(ModelNameTextBox.Text);
                            break;
                    }
                }
            }

            File.WriteAllText($"{PathToGTAVTextBox.Text}\\scripts\\AddedTraffic.xml", xml.SerializeXml());
        }
    }

    public static class Extensions
    {
        public static T DeserializeXml<T>(this string xml)
        {
            var serializer = new XmlSerializer(typeof(T));
            using var reader = new StringReader(xml);
            return (T)serializer.Deserialize(reader);
        }

        public static string SerializeXml<T>(this T obj)
        {
            var serializer = new XmlSerializer(typeof(T));
            using var writer = new StringWriter();
            serializer.Serialize(writer, obj);
            return writer.ToString();
        }

        public static IEnumerable<T> DistinctBy<T, TKey>(this IEnumerable<T> items, Func<T, TKey> property)
        {
            return items.GroupBy(property).Select(x => x.First());
        }

        public static T[] Add<T>(this T[] array, T item)
        {
            var list = array.ToList();

            list.Add(item);

            return list.ToArray();
        }
    }
}