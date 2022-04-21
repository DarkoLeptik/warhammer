// See https://aka.ms/new-console-template for more information
using WarhammerManager;
using OrcsAndMarines;
using System;
using WarhammerManager.Equipments;
using WarhammerManager.Rules;




Console.WriteLine("Hello, World!");
//ArmyFactory.CreateArmy();

var myArmy = ArmyFactory.CreateArmy<Ork>("metamaus ©");
var mySquad = ArmyFactory.CreateSquad<Ork, SluggaBoyz>(myArmy.MyArmy);
var myBoyy = new Nob((SluggaBoyz)mySquad.MySquad); // TODO change this

var bigWeapon = new Weapon("BoomBoom", 50, 3);

myBoyy.AddWeapon(bigWeapon);

myArmy.MyArmy.myConstraints.AddAuthorizedEquipment(bigWeapon.equipmentName);

myBoyy.AddWeapon(bigWeapon);

myBoyy.RemoveWeapon(bigWeapon);
myBoyy.RemoveWeapon(bigWeapon);

var myInstance = RulesFactory.Instance;

var myRule = new Rule(3, -1);

Console.WriteLine(myBoyy);
myBoyy.AddRules(myRule);
Console.WriteLine(myBoyy);
myBoyy.AddRules(myRule);
Console.WriteLine(myBoyy);
myBoyy.DeleteRules(myRule);
Console.WriteLine(myBoyy);
myBoyy.DeleteRules(myRule);