using UnityEngine;
using ShonEagle.Tools.UI;
using ShonEagle.Tools.Utility;
using Yudiz.SquareBird.Utility;


namespace Yudiz.SquareBird.Manager
{
    public class GameManager : Singleton<GameManager>
    {
        #region PUBLIC_VARS
        public GlobalSettings GS;
        #endregion

        #region PRIVATE_VARS        
        #endregion

        #region UNITY_CALLBACKS
        private void OnEnable()
        {
            GameEvents.OnGameOver += ShowGamOverScreen;
        }

        private void OnDisable()
        {
            GameEvents.OnGameOver -= ShowGamOverScreen;
        }
        #endregion

        #region STATIC_FUNCTIONS
        public static float Map(float value, float leftMin, float leftMax, float rightMin, float rightMax)
        {
            return rightMin + (value - leftMin) * (rightMax - rightMin) / (leftMax - leftMin);
        }
        #endregion

        #region PUBLIC_FUNCTIONS        
        #endregion

        #region PRIVATE_FUNCTIONS
        private void ShowGamOverScreen()
        {
            ViewController.Instance.ChangeView(ScreenName.GameOver);
        }
        #endregion

        #region CO-ROUTINES           
        #endregion

        #region EVENT_HANDLERS
        #endregion

        #region UI_CALLBACKS        
        #endregion        
    }
}