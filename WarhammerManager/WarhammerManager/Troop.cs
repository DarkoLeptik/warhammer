using System;
using WarhammerManager.Equipments;
using WarhammerManager.Rules;

namespace WarhammerManager
{
    public class Troop<T1, T2> : IRulable
        where T1 : Army
        where T2 : Squad<T1>
    {
        private Squad<T1>? _mySquad;

        public Squad<T1>? MySquad
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
        
        public Troop()
        {
            _rulesApplied = new List<Rule>();
            _mySquad = null;
            _equippedWeapons = new List<Weapon>();
        }
        
        public static explicit operator Troop<T1, Squad<T1>> (Troop<T1, T2> n)
        {
            return new Troop<T1, Squad<T1>>(n._rulesApplied, n._mySquad, n._equippedWeapons, n._equippedArmor);
        }

        internal Troop (List<Rule> rulesApplied, Squad<T1>? mySquad, List<Weapon> equippedWeapons, Armor? armor)
        {
            _rulesApplied = new List<Rule>();

            foreach (var rule in rulesApplied)
            {
                this.AddRules(rule);
            }
            
            if (mySquad != null)
            {
                _mySquad = (T2)mySquad;  
            }
            _equippedWeapons = new List<Weapon>(equippedWeapons);
            if (armor != null)
            {
                AddArmor(armor);
            }
        }

        internal void AddToSquad(Squad<T1> newSquad)
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

        public void AddRules(Rule rule)
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

        public void DeleteRules(Rule rule)
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