// See https://aka.ms/new-console-template for more information
using WarhammerManager;
using OrcsAndMarines;
using System;
using WarhammerManager.Equipments;
using WarhammerManager.Rules;

Console.WriteLine("[[[[ WELCOME TO THE WARHAMMER ARMY MANAGER ]]]]");

var myArmy = ArmyFactory.CreateArmy<Ork>("Ork army");
var mySquad = ArmyFactory.CreateSquad<Ork, SluggaBoyz>(myArmy);
var myBoyy = ArmyFactory.CreateTroop<Ork, SluggaBoyz, Nob>(mySquad);
var myHulk = ArmyFactory.CreateTroop<Ork, SluggaBoyz, Hulk>(mySquad);

Console.WriteLine(myArmy);