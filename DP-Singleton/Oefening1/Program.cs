// Deze oefening heeft een Singleton class voor een databaseverbinding.
// Sla 3 strings op in de database. Na elke string toon je op je scherm 
// de inhoud van de database.

using Oefening1;

DatabaseConnection.Instance().SaveData("tekst 1");
printContent();

DatabaseConnection.Instance().SaveData("tekst 2");
printContent();

DatabaseConnection.Instance().SaveData("tekst 3");
printContent();


void printContent()
{
    foreach (var item in DatabaseConnection.Instance().GetData())
    {
        Console.WriteLine(item);
    }
}

