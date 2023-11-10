using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

namespace Yudiz.SquareBird.Levels
{
    public class LevelEditor : MonoBehaviour
    {
        #region PUBLIC_VARS
        public List<GameObject> normalPrefabs;
        public List<GameObject> hardPrefabs;
        #endregion

        #region PRIVATE_VARS
        private GameObject currentLevel;
        #endregion

        #region PUBLIC_FUNCTIONS
        public void GenerateLevel(int stage)
        {
            // Destroy the current level if it exists
            if (currentLevel != null)
            {
                DestroyImmediate(currentLevel);
            }

            // Create a new empty GameObject to hold the level
            currentLevel = new GameObject("Level" + stage);

            // Choose the prefabs based on the stage number
            List<GameObject> prefabs = stage <= 5 ? normalPrefabs : hardPrefabs;

            // Instantiate the prefabs and parent them to the level GameObject
            foreach (GameObject prefab in prefabs)
            {
                Instantiate(prefab, currentLevel.transform);
            }                      
        }

        public void SaveAsPrefab()
        {
            // Save the current level as a prefab
            string localPath = "Assets/" + currentLevel.name + ".prefab";
            localPath = AssetDatabase.GenerateUniqueAssetPath(localPath);
            PrefabUtility.SaveAsPrefabAssetAndConnect(currentLevel, localPath, InteractionMode.UserAction);
        }
        #endregion
    }
}