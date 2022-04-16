// See https://aka.ms/new-console-template for more information
using WarhammerManager;
using OrcsAndMarines;
using System;
using WarhammerManager.Rules;




Console.WriteLine("Hello, World!");
//ArmyFactory.CreateArmy();

//var myArmy = new Ork();
var myArmy = ArmyFactory.CreateArmy<Ork>("metamaus ©");
var mySquad = ArmyFactory.CreateSquad<Ork, SluggaBoyz>(myArmy.MyArmy);
//var mySquad = ArmyFactory.CreateSquad<>;
//var myBoyz = new SluggaBoyz(myArmy);
//var mySquad = new SquadContainer<Ork>(myBoyz);


var myInstance = RulesFactory.Instance;


