using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class ArchetypesChoice : MonoBehaviour
    {
        private Player _player;
        private GameObject archetypes;
        [SerializeField] private GameObject card;
        [SerializeField] private GameObject swipe;

        private void Start()
        {
            _player = FindObjectOfType<Player>();
            archetypes = GameObject.FindGameObjectWithTag("archetypeMenu");
            
            card.SetActive(false);
            swipe.SetActive(false);
            
        }

        public void Ratus()
        {
            _player.Hunger = Archetype.Ratus.hunger;
            _player.Sold = Archetype.Ratus.sold;
            _player.Social = Archetype.Ratus.sociability;
            _player.Knowledge = Archetype.Ratus.knowledge;
            archetypes.SetActive(false);
            card.SetActive(true);
            swipe.SetActive(true);

        }
        public void Leader()
        {
            _player.Hunger = Archetype.Leader.hunger;
            _player.Sold = Archetype.Leader.sold;
            _player.Social = Archetype.Leader.sociability;
            _player.Knowledge = Archetype.Leader.knowledge;
            archetypes.SetActive(false);
            card.SetActive(true);
            swipe.SetActive(true);

        }
        public void Acharné()
        {
            _player.Hunger = Archetype.Acharné.hunger;
            _player.Sold = Archetype.Acharné.sold;
            _player.Social = Archetype.Acharné.sociability;
            _player.Knowledge = Archetype.Acharné.knowledge;
            archetypes.SetActive(false);
            card.SetActive(true);
            swipe.SetActive(true);

        }
        public void Gamer()
        {
            _player.Hunger = Archetype.Gamer.hunger;
            _player.Sold = Archetype.Gamer.sold;
            _player.Social = Archetype.Gamer.sociability;
            _player.Knowledge = Archetype.Gamer.knowledge;
            archetypes.SetActive(false);
            card.SetActive(true);
            swipe.SetActive(true);

        }

    }
}