// Herwerk dit programma en maak van de SettingsManager een Singleton

using Oefening2;

// Creëer een nieuwe instantie van de SettingsManager class
SettingsManager settingsManager1 = SettingsManager.Instance();

// Sla enkele instellingen op
settingsManager1.SaveSetting("Taalaanpassing", "Nederlands");
settingsManager1.SaveSetting("Resolutie", "1920x1080");

// Haal de instellingen op en toon ze op het scherm
Console.WriteLine("Eerste SettingsManager:");
Console.WriteLine($"Taalaanpassing: {settingsManager1.GetSetting("Taalaanpassing")}");
Console.WriteLine($"Resolutie: {settingsManager1.GetSetting("Resolutie")}");

// Creëer een andere instantie van de SettingsManager class en toon aan dat het dezelfde is als de eerste
SettingsManager settingsManager2 = SettingsManager.Instance();
Console.WriteLine("\nTweede SettingsManager Instance:");
Console.WriteLine($"Taalaanpassing: {settingsManager2.GetSetting("Taalaanpassing")}");
Console.WriteLine($"Resolutie: {settingsManager2.GetSetting("Resolutie")}");

// Toon dat beide variabelen naar dezelfde instantie wijzen
Console.WriteLine("\nZijn beide instances gelijk?");
Console.WriteLine(object.ReferenceEquals(settingsManager1, settingsManager2));
