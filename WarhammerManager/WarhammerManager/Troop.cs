﻿using System;
using WarhammerManager.Equipments;
using WarhammerManager.Rules;

namespace WarhammerManager
{
    public abstract class Troop<T1, T2> : Rulable
        where T1 : Army
        where T2 : Squad<T1>
    {
        private T2? _mySquad;

        public T2? MySquad
        {
            get
            {
                return _mySquad;
            }
            internal set
            {
                _mySquad = value;
            }
        }
        public int Attack { get; internal set; }

        public int Armor { get; internal set; }

        private List<Rule> _rulesApplied;
        internal List<Rule> RulesApplied
        {
            get { return _rulesApplied; }
            set { _rulesApplied = value; }
        }

        private Armor? _equippedArmor;
        private List<Weapon> _equippedWeapons;
        
        public AuthorizedEquipments myConstraints = new AuthorizedEquipments();
        
        protected Troop()
        {
            _rulesApplied = new List<Rule>();
            _mySquad = null;
            _equippedWeapons = new List<Weapon>();
        }

        internal void AddToSquad(T2 newSquad)
        {
            _mySquad ??= newSquad;
        }

        public override string ToString()
        {
            string description = "<- " + this.GetType().Name + " ->\nAttack: " + Attack + "\nDefense: " + Armor + "\n";

            if (_equippedArmor != null)
            {
                description += "Armor: " + _equippedArmor;
            }

            if (_equippedWeapons.Count > 0)
            {
                description += "Weapons:\n";
                foreach (var weapon in _equippedWeapons)
                {
                    description += " - " + weapon + "\n";
                }
            }
            
            return description;
        }

        void Rulable.AddRules(Rule rule)
        {
            if (_rulesApplied.Contains(rule))
            {
                Console.WriteLine("This rule has already been applied to this troop.");
            }
            else
            {
                rule.ApplyRuleToTroop(this);
            }
        }

        void Rulable.DeleteRules(Rule rule)
        {
            if (_rulesApplied.Contains(rule))
            {
                rule.RemoveRuleToTroop(this);
            }
            else
            {
                Console.WriteLine("This rule isn't applied to this troop.");
            }
        }

        private bool IsEquipmentAuthorized(string name)
        {
            if (myConstraints.FindEquipment(name))
            {
                return true;
            }

            return _mySquad != null && _mySquad.IsEquipmentAuthorized(name);
        }

        // Equip an armor if none is equipped, and return false if one is already equipped
        public bool AddArmor(Armor newArmor)
        {
            if (IsEquipmentAuthorized(newArmor.EquipmentName) && _equippedArmor == null)
            {
                _equippedArmor = newArmor;
                Armor += newArmor.DefenseStat;
                
                Console.WriteLine(newArmor.EquipmentName + " was equipped !");
                
                return true;
            }
            
            Console.WriteLine(newArmor.EquipmentName + " wasn't equipped.");
            return false;
        }

        public Armor? RemoveArmor()
        {
            Armor? removedArmor = _equippedArmor;
            if (removedArmor != null)
            {
                Armor -= removedArmor.DefenseStat;
                _equippedArmor = null;
            }
            return removedArmor;
        }

        public bool AddWeapon(Weapon newWeapon)
        {
            if (IsEquipmentAuthorized(newWeapon.EquipmentName))
            {
                _equippedWeapons.Add(newWeapon);
                Console.WriteLine(newWeapon.EquipmentName + " was equipped !");
                return true;
            }
            
            Console.WriteLine(newWeapon.EquipmentName + " wasn't equipped.");
            return false;
        }

        public bool RemoveWeapon(Weapon weaponToRemove)
        {
            return _equippedWeapons.Remove(weaponToRemove);
        }
    }
}