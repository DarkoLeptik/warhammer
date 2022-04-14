// See https://aka.ms/new-console-template for more information
using WarhammerManager;
using OrcsAndMarines;
using System;



Console.WriteLine("Hello, World!");
ArmyFactory.CreateArmy();

var myArmy = new Ork();
var myBoyz = new SluggaBoyz(myArmy);
var mySquad = new SquadContainer<Ork>(myBoyz);

var myArmyContainer = new ArmyContainer<Ork>(myArmy);
myArmyContainer.AddSquad(mySquad);

var myInstance = RulesFactory.Instance;


