using UnityEngine;

namespace Patterns.Builder
{
    public class HouseSpawner : MonoBehaviour
    {
        [SerializeField]
        private Transform houseParent;

        [SerializeField]
        private GameObject wallsPrefab;

        [SerializeField]
        private GameObject roofPrefab;

        [SerializeField]
        private GameObject doorPrefab;

        [SerializeField]
        private GameObject windowsPrefab;

        private House _house;

        private void Awake() => _house = new House(houseParent);

        public void ResetHouse() => _house.Clear();

        public void SpawnHouse()
        {
            _house = new House.HouseBuilder(_house)
                .AddWalls(wallsPrefab)
                .AddDoor(doorPrefab)
                .AddRoof(roofPrefab)
                .AddWindows(windowsPrefab)
                .Build();
        }

        public void AddDoor()
        {
            _house = new House.HouseBuilder(_house)
                .AddDoor(doorPrefab)
                .Build();
        }

        public void AddWindows()
        {
            _house = new House.HouseBuilder(_house)
                .AddWindows(windowsPrefab)
                .Build();
        }

        public void AddRoof()
        {
            _house = new House.HouseBuilder(_house)
                .AddRoof(roofPrefab)
                .Build();
        }

        public void AddWalls()
        {
            _house = new House.HouseBuilder(_house)
                .AddWalls(wallsPrefab)
                .Build();
        }
    }
}