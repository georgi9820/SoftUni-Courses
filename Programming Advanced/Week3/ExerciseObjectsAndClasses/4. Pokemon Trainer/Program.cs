string inputData = Console.ReadLine();

Dictionary<string, Trainer> trainers = new();

while (inputData != "Tournament")
{
    string[] dataArr = inputData.Split();
    string trainerName = dataArr[0];
    string pokemonName = dataArr[1];
    string pokemonElement = dataArr[2];
    int pokemonHealth = int.Parse(dataArr[3]);

    if (!trainers.ContainsKey(trainerName))
    {
        trainers[trainerName] = new Trainer(trainerName);
    }

    Pokemon newPokemon = new(pokemonName, pokemonElement, pokemonHealth);
    trainers[trainerName].Pokemons.Add(newPokemon);

    inputData = Console.ReadLine();
}

string input;
while ((input = Console.ReadLine()) != "End")
{
    switch (input)
    {
        case "Fire":
            foreach(var trainer in trainers.Values)
            {
               if(trainer.Pokemons.Any(p => p.Element == "Fire"))
                {
                    trainer.NumberOfBadges++;
                }
                else
                {
                    List<Pokemon> pokemonsToRemove = new List<Pokemon>();

                    foreach (var pokemon in trainer.Pokemons)
                    {
                        if (pokemon.Element != input)
                        {
                            pokemon.Health -= 10;

                            if (pokemon.Health <= 0)
                            {
                                pokemonsToRemove.Add(pokemon);
                            }
                        }
                        else
                        {
                            trainer.NumberOfBadges++;
                        }
                    }

                    foreach (var pokemonToRemove in pokemonsToRemove)
                    {
                        trainer.Pokemons.Remove(pokemonToRemove);
                    }
                }
            }
            break;
        case "Water":
            foreach (var trainer in trainers.Values)
            {
                if (trainer.Pokemons.Any(p => p.Element == "Water"))
                {
                    trainer.NumberOfBadges++;
                }
                else
                {
                    List<Pokemon> pokemonsToRemove = new List<Pokemon>();

                    foreach (var pokemon in trainer.Pokemons)
                    {
                        if (pokemon.Element != input)
                        {
                            pokemon.Health -= 10;

                            if (pokemon.Health <= 0)
                            {
                                pokemonsToRemove.Add(pokemon);
                            }
                        }
                        else
                        {
                            trainer.NumberOfBadges++;
                        }
                    }

                    foreach (var pokemonToRemove in pokemonsToRemove)
                    {
                        trainer.Pokemons.Remove(pokemonToRemove);
                    }
                }
            }
            break;
        case "Electricity":
            foreach (var trainer in trainers.Values)
            {
                if (trainer.Pokemons.Any(p => p.Element == "Electricity"))
                {
                    trainer.NumberOfBadges++;
                }
                else
                {
                    List<Pokemon> pokemonsToRemove = new List<Pokemon>();

                    foreach (var pokemon in trainer.Pokemons)
                    {
                        if (pokemon.Element != input)
                        {
                            pokemon.Health -= 10;

                            if (pokemon.Health <= 0)
                            {
                                pokemonsToRemove.Add(pokemon);
                            }
                        }
                        else
                        {
                            trainer.NumberOfBadges++;
                        }
                    }

                    foreach (var pokemonToRemove in pokemonsToRemove)
                    {
                        trainer.Pokemons.Remove(pokemonToRemove);
                    }
                }
            }
            break;
    }
}

foreach (var trainer in trainers.Values
    .Select((value, index) => new { Trainer = value, Order = index })
    .OrderByDescending(x => x.Trainer.NumberOfBadges)
    .ThenBy(x => x.Order))
{
    Console.WriteLine($"{trainer.Trainer.Name} {trainer.Trainer.NumberOfBadges} {trainer.Trainer.Pokemons.Count}");
}

