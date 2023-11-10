using System;
using UnityEngine;

namespace Yudiz.SquareBird.Utility
{
    public static class GameEvents
    {
        #region PUBLIC_VARS
        public static Action OnScreenTapped;
        public static Action OnGameStart;
        public static Action OnGameOver;
        public static Action OnEnableBirdControls;
        public static Action OnDisableBirdControls;
        public static Action OnEndZoneReached;
        public static Action OnLevelComplete;
        public static Action<int> OnUpdateScore;
        public static Action<float, float, float> OnLevelProgress;        

        //public delegate float GameDelegate(float startPoint, float endPoint, Transform LevelTransform);
        //public static GameDelegate OnLevelProgress;
        #endregion

        #region PRIVATE_VARS
        #endregion

        #region UNITY_CALLBACKS        
        #endregion

        #region STATIC_FUNCTIONS
        #endregion

        #region PUBLIC_FUNCTIONS
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