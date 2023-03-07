using Pokedex;
using Projeto_1;

Pokemon[] Listapokemons = new Pokemon[151];
#region #1
Listapokemons[1] = new Planta("Bulbasaur", "Planta");
Listapokemons[1].evolucoes = "Para: Ivysaur";
Listapokemons[1].descricao = "O bulbo em suas costas está cheio de nutrientes. Nele, Bulbasaur armazena suas energias. O bulbo vai crescendo à medida que envelhece porque ele absorve os raios de sol.";
Listapokemons[1].HP = 45;
Listapokemons[1].ATK = 49;
Listapokemons[1].DEF = 49;
Listapokemons[1].SPATK = 65;
Listapokemons[1].SPDEF = 65;
Listapokemons[1].VEL = 45;


Pokemon Bulbasaur = new Planta("Bulbasaur", "Planta");
    
Bulbasaur.evolucoes = "Para: Ivysaur";
Bulbasaur.descricao = "O bulbo em suas costas está cheio de nutrientes. Nele, Bulbasaur armazena suas energias. O bulbo vai crescendo à medida que envelhece porque ele absorve os raios de sol.";
Bulbasaur.HP = 45;
Bulbasaur.ATK = 49;
Bulbasaur.DEF = 49;
Bulbasaur.SPATK = 65;
Bulbasaur.SPDEF = 65;
Bulbasaur.VEL = 45;

Console.WriteLine("Pokémon: "+Listapokemons[1].nome );
Console.WriteLine("#" + Listapokemons[1].ID);
Console.WriteLine("Tipo: " + Listapokemons[1].tipo);
Console.WriteLine("Evoluções: " + Listapokemons[1].evolucoes);
Console.WriteLine("\nDescrição: " + Listapokemons[1].descricao);
Console.WriteLine("\nHP: " + Listapokemons[1].HP);
Console.WriteLine("ATK: " + Listapokemons[1].ATK);
Console.WriteLine("DEF: " + Listapokemons[1].DEF);
Console.WriteLine("SPATK: " + Listapokemons[1].SPATK);
Console.WriteLine("SPDEF: " + Listapokemons[1].SPDEF);
Console.WriteLine("VEL: " + Listapokemons[1].VEL);

char parar;
Console.ReadLine();
#endregion

//Pokemon Ivysaur = new Planta("Ivysaur", "Planta");


//Ivysaur.evolucoes = "Para: Vanusaur";
//Ivysaur.descricao = "O bulbo em suas costas está cheio de nutrientes. Nele, Bulbasaur armazena suas energias. O bulbo vai crescendo à medida que envelhece porque ele absorve os raios de sol.";
//Ivysaur.HP = 60;
//Ivysaur.ATK = 62;
//Ivysaur.DEF = 63;
//Ivysaur.SPATK = 80;
//Ivysaur.SPDEF = 80;
//Ivysaur.VEL = 60;

//Console.WriteLine("Pokémon: " + Ivysaur.nome);
//Console.WriteLine("#" + Ivysaur.ID);
//Console.WriteLine("Tipo: " + Ivysaur.tipo);
//Console.WriteLine("Evoluções: " + Ivysaur.evolucoes);
//Console.WriteLine("\nDescrição: " + Ivysaur.descricao);
//Console.WriteLine("\nHP: " + Ivysaur.HP);
//Console.WriteLine("ATK: " + Ivysaur.ATK);
//Console.WriteLine("DEF: " + Ivysaur.DEF);
//Console.WriteLine("SPATK: " + Ivysaur.SPATK);
//Console.WriteLine("SPDEF: " + Ivysaur.SPDEF);
//Console.WriteLine("VEL: " + Ivysaur.VEL);