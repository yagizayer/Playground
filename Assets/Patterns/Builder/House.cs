using System.Linq;
using UnityEngine;

namespace Patterns.Builder
{
    public class House
    {
        private GameObject _walls;
        private GameObject _roof;
        private GameObject _door;
        private GameObject _windows;
        private readonly Transform _root;

        public House(Transform root) => _root = root;

        public void Clear()
        {
            var objectsToRemove = _root.Cast<Transform>().ToList();
            foreach (var obj in objectsToRemove) Object.Destroy(obj.gameObject);
        }

        public class HouseBuilder
        {
            private readonly House _house;
            public HouseBuilder(House house) => _house = house;

            public HouseBuilder AddWalls(GameObject wallsPrefab)
            {
                if (_house._walls != null) return this;
                var walls = Object.Instantiate(wallsPrefab, _house._root);
                _house._walls = walls;
                return this;
            }

            public HouseBuilder AddRoof(GameObject roofPrefab)
            {
                if (_house._roof != null) return this;
                var roof = Object.Instantiate(roofPrefab, _house._root);
                _house._roof = roof;
                return this;
            }

            public HouseBuilder AddDoor(GameObject doorPrefab)
            {
                if (_house._door != null) return this;
                var door = Object.Instantiate(doorPrefab, _house._root);
                _house._door = door;
                return this;
            }

            public HouseBuilder AddWindows(GameObject windowsPrefab)
            {
                if (_house._windows != null) return this;
                var windows = Object.Instantiate(windowsPrefab, _house._root);
                _house._windows = windows;
                return this;
            }

            public House Build() => _house;
        }
    }
}