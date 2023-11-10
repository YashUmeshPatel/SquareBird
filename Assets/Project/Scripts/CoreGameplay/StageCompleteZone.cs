using UnityEngine;
using Yudiz.SquareBird.Utility;
using ShonEagle.Tools.UI;

namespace Yudiz.SquareBird.CoreGamePlay
{
    public class StageCompleteZone : MonoBehaviour
    {
        #region PUBLIC_VARS
        #endregion

        #region PRIVATE_VARS
        #endregion

        #region UNITY_CALLBACKS
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.GetComponent<Bird>() != null)
            {
                GameEvents.OnLevelComplete?.Invoke();
                ViewController.Instance.ChangeView(ScreenName.LevelComplete);
            }
        }
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