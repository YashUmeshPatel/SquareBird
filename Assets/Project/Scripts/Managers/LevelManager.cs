using UnityEngine;
using ShonEagle.Tools.Utility;
using Yudiz.SquareBird.Utility;

namespace Yudiz.SquareBird.Levels
{
    public class LevelManager : Singleton<LevelManager>
    {
        #region PUBLIC_VARS
        #endregion

        #region PRIVATE_VARS
        [SerializeField] private Transform levelParent;

        private int currentLevel = 0;
        private GameObject levelGameObject;
        #endregion

        #region UNITY_CALLBACKS        
        #endregion

        #region STATIC_FUNCTIONS
        #endregion

        #region PUBLIC_FUNCTIONS
        public void LoadLevel(int index)
        {
            if(index > LevelData.Instance.levelPrefabs.Count) { return; }

            currentLevel = index;            
            levelGameObject = Instantiate(LevelData.Instance.levelPrefabs[index].gameObject, levelParent);
        }

        [EasyButtons.Button]
        public void NextLevel()
        {
            if(levelGameObject == null) { return; }

            Destroy(levelGameObject);

            if(++currentLevel > LevelData.Instance.levelPrefabs.Count) { return; }
            LoadLevel(++currentLevel);
        }
        
        public void Reload()
        {
            Destroy(levelGameObject);
            LoadLevel(currentLevel);
        }
        #endregion

        #region PRIVATE_FUNCTIONS
        #endregion

        #region CO-ROUTINES
        #endregion

        #region EVENT_HANDLERS
        #endregion

        #region UI_CALLBACKS
        #endregion
    }
}