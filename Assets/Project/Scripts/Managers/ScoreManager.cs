using UnityEngine;
using Yudiz.SquareBird.Utility;
using ShonEagle.Tools.Utility;

namespace Yudiz.SquareBird.Manager
{
    public class ScoreManager : Singleton<ScoreManager>
    {
        #region PUBLIC_VARS
        #endregion

        #region PRIVATE_VARS
        private int score;
        #endregion

        #region UNITY_CALLBACKS     
        #endregion

        #region STATIC_FUNCTIONS
        #endregion

        #region PUBLIC_FUNCTIONS
        public void UpdateScore(int score)
        {
            this.score += score;
            GameEvents.OnUpdateScore?.Invoke(this.score);
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