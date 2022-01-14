string[] automerken = { "Nissan", "Toyota", "Mercedes", "Volkswagen", "Opel", "Opel" };
Array.Sort(automerken);
Array.Resize(ref automerken, 7);
automerken.SetValue("Audi", 6);

Console.WriteLine(automerken);