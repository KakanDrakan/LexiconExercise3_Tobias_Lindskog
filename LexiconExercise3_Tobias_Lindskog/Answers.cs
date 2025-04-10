/*
 
F: Vad händer om du försöker lägga till en Car i en lista av Motorcycle? 
A: Går inte för C# är type safe. Compile error. Lista av Motorcycle kan bara hålla objekt av klassen Motorcycle

F: Vilken typ bör en lista vara för att rymma alla fordonstyper? 
A: Vehicle, eftersom det är basklassen

F: Kommer du åt metoden Clean() från en lista med typen List<Vehicle>? 
A: Ja via ex: 
    if(vehicle is ICleanable cleanable) cleanable.Clean(), 
men inte från vehicle.Clean()

F: Vad är fördelarna med att använda ett interface här istället för arv? 
A: Eftersom inte alla fordon är cleanable vill vi bara att vissa subklasser av dem ska ha tillgång till Clean(). 
En klass kan bara ha en basklass, så vi låter alla fordon vara av klassen Vehicles och använder interfacet ICleanable endast på dem som är cleanable.
Att skapa metoden Clean() under basklassen Vehicle med en bool isCleanable hade också funkat men är betydligt stökigare och mindre tydligt.
 
 
 */