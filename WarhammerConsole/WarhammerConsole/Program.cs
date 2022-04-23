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

var bigWeapon = new Weapon("BoomBoom", 50);
var armor = new Armor("Leather armor", 14);
var bigCanon = new RangedWeapon("Distant boom boom", 8, 45);

myBoyy.AddWeapon(bigWeapon);

myArmy.MyArmy.MyAuthorizedEquipments.AddAuthorizedEquipment(bigWeapon.EquipmentName);
mySquad.MySquad.MyAuthorizedEquipments.AddAuthorizedEquipment(bigCanon.EquipmentName);
myHulk.myConstraints.AddAuthorizedEquipment(armor.EquipmentName);

myBoyy.AddWeapon(bigWeapon);

myHulk.AddArmor(armor);
myBoyy.AddWeapon(bigCanon);

Console.WriteLine(mySquad);

myBoyy.RemoveWeapon(bigWeapon);
myBoyy.RemoveWeapon(bigWeapon);


var instance = RulesFactory.Instance;

int ruleIndex = instance.CreateRule(3, -1, "Berserker");
Console.WriteLine(myBoyy);
instance.ApplyRule(myBoyy, ruleIndex);
Console.WriteLine(myBoyy);
instance.ApplyRule(myBoyy, ruleIndex);
Console.WriteLine(myBoyy);