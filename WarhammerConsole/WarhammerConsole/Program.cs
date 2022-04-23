// See https://aka.ms/new-console-template for more information
using WarhammerManager;
using OrcsAndMarines;
using System;
using WarhammerManager.Equipments;
using WarhammerManager.Rules;

Console.WriteLine("[[[[ WELCOME TO THE WARHAMMER ARMY MANAGER ]]]]");

var myArmy = ArmyFactory.CreateArmy<Ork>("Ork army");
var mySluggaSquad = ArmyFactory.CreateSquad<Ork, SluggaBoyz>(myArmy);
var myNob = ArmyFactory.CreateTroop<Ork, SluggaBoyz, Nob>(mySluggaSquad);
var myHulk = ArmyFactory.CreateTroop<Ork, SluggaBoyz, Hulk>(mySluggaSquad);
var myShootSquad = ArmyFactory.CreateSquad<Ork, Shootagyrls>(myArmy);
var myWaag = ArmyFactory.CreateTroop<Ork, Shootagyrls, Waag>(myShootSquad);
var myWyld = ArmyFactory.CreateTroop<Ork, Shootagyrls, Wyld>(mySluggaSquad);

var my2NdArmy = ArmyFactory.CreateArmy<SpaceMarines>("SpaceMarines Army");
var mySpaceSquad = ArmyFactory.CreateSquad<SpaceMarines, Specialists>(my2NdArmy);
var myRagnar = ArmyFactory.CreateTroop<SpaceMarines, Specialists, Ragnar>(mySpaceSquad);
var mySniper = ArmyFactory.CreateTroop<SpaceMarines, Specialists, Sniper>(mySpaceSquad);

Console.WriteLine(myArmy);
Console.WriteLine(my2NdArmy);

Console.WriteLine(RulesFactory.Instance.ListOfRules());