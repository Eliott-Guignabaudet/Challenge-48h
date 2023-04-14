using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class ArchetypesChoice : MonoBehaviour
    {
        private Player _player;
        private GameObject archetypes;

        private void Start()
        {
            _player = FindObjectOfType<Player>();
            archetypes = GameObject.FindGameObjectWithTag("archetypeMenu");
        }

        public void Analyst()
        {
            _player.Hunger = Archetype.Analyst.hunger;
            _player.Sold = Archetype.Analyst.sold;
            _player.Social = Archetype.Analyst.sociability;
            _player.Knowledge = Archetype.Analyst.knowledge;
            archetypes.SetActive(false);
        }
        public void Explorer()
        {
            _player.Hunger = Archetype.Analyst.hunger;
            _player.Sold = Archetype.Analyst.sold;
            _player.Social = Archetype.Analyst.sociability;
            _player.Knowledge = Archetype.Analyst.knowledge;
            archetypes.SetActive(false);
        }
        public void Sentinel()
        {
            _player.Hunger = Archetype.Analyst.hunger;
            _player.Sold = Archetype.Analyst.sold;
            _player.Social = Archetype.Analyst.sociability;
            _player.Knowledge = Archetype.Analyst.knowledge;
            archetypes.SetActive(false);
        }
        public void Diplomat()
        {
            _player.Hunger = Archetype.Analyst.hunger;
            _player.Sold = Archetype.Analyst.sold;
            _player.Social = Archetype.Analyst.sociability;
            _player.Knowledge = Archetype.Analyst.knowledge;
            archetypes.SetActive(false);
        }
        
    }
}