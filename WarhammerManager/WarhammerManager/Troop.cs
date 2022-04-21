using System;
using WarhammerManager.Equipments;
using WarhammerManager.Rules;

namespace WarhammerManager
{
    public abstract class Troop<T1, T2> : Rulable
        where T1 : Squad<T2>
        where T2 : Army
    {
        private T1 _mySquad;

        public T1 MySquad
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
        public List<Rule> RulesApplied
        {
            get { return _rulesApplied; }
            set { _rulesApplied = value; }
        }

        private Armor? _equippedArmor;
        private List<Weapon> _equippedWeapons;
        
        public AuthorizedEquipments myConstraints = new AuthorizedEquipments();
        
        protected Troop(T1 newSquad)
        {
            _rulesApplied = new List<Rule>();
            _mySquad = newSquad;
            _equippedWeapons = new List<Weapon>();
        }

        public override string ToString()
        {
            return "Atk: " + Attack + " Armor: " + Armor;
        }

        public void AddRules(Rule rule)
        {
            if (_rulesApplied.Contains(rule))
            {
                Console.WriteLine("Cette règle est déjà appliquée à cette arme");
            }
            else
            {
                rule.ApplyRuleToTroop<T1, T2>(this);
            }
        }

        public void DeleteRules(Rule rule)
        {
            if (_rulesApplied.Contains(rule))
            {
                rule.RemoveRuleToTroop<T1, T2>(this);
            }
            else
            {
                Console.WriteLine("Cette règle n'est pas appliquée à cette arme");
            }
        }

        private bool IsEquipmentAuthorized(string name)
        {
            if (myConstraints.FindEquipment(name))
            {
                return true;
            }

            return _mySquad.IsEquipmentAuthorized(name);
        }

        // Equip an armor if none is equipped, and return false if one is already equipped
        public bool AddArmor(Armor newArmor)
        {
            if (IsEquipmentAuthorized(newArmor.equipmentName) && _equippedArmor == null)
            {
                _equippedArmor = newArmor;
                Armor += newArmor.DefenseStat;
                
                Console.WriteLine(newArmor.equipmentName + " was equipped !");
                
                return true;
            }
            
            Console.WriteLine(newArmor.equipmentName + " wasn't equipped.");
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
            if (IsEquipmentAuthorized(newWeapon.equipmentName))
            {
                _equippedWeapons.Add(newWeapon);
                Console.WriteLine(newWeapon.equipmentName + " was equipped !");
                return true;
            }
            
            Console.WriteLine(newWeapon.equipmentName + " wasn't equipped.");
            return false;
        }

        public bool RemoveWeapon(Weapon weaponToRemove)
        {
            return _equippedWeapons.Remove(weaponToRemove);
        }
    }
}