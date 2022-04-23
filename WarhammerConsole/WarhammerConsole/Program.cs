// See https://aka.ms/new-console-template for more information
using WarhammerManager;
using OrcsAndMarines;
using System;
using WarhammerManager.Equipments;
using WarhammerManager.Rules;

Console.WriteLine("[[[[ WELCOME TO THE WARHAMMER ARMY MANAGER ]]]]");

//var myArmy = ArmyFactory.CreateArmy<Ork>("Ork army");
//var mySquad = ArmyFactory.CreateSquad<Ork, SluggaBoyz>(myArmy);
//var myWaag = ArmyFactory.CreateTroop<Ork, Shootagyrls, Waag>(mySquad);
//var myWyld = ArmyFactory.CreateTroop<Ork, Shootagyrls, Wyld>(mySquad);

var myArmy = ArmyFactory.CreateArmy<SpaceMarines>("SpaceMarines Army");
var mySquad = ArmyFactory.CreateSquad<SpaceMarines, Specialists>(myArmy);
var myRagnar = ArmyFactory.CreateTroop<SpaceMarines, Specialists, Ragnar>(mySquad);
var mySniper = ArmyFactory.CreateTroop<SpaceMarines, Specialists, Sniper>(mySquad);

Console.WriteLine(myArmy);