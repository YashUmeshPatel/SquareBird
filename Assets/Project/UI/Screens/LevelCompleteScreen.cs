using UnityEngine;
using ShonEagle.Tools.UI;
using UnityEngine.UI;
using Yudiz.SquareBird.Levels;
using Yudiz.SquareBird.Utility;
using Screen = ShonEagle.Tools.UI.Screen;

namespace Yudiz.SquareBird.UI
{
    public class LevelCompleteScreen : Screen
    {
        #region PUBLIC_VARS
        #endregion

        #region PRIVATE_VARS
        [SerializeField] private Button nxtBtn;
        #endregion

        #region UNITY_CALLBACKS        
        #endregion

        #region UI_CALLBACKS
        public override void Show()
        {
            base.Show();

            nxtBtn.onClick.AddListener(OnNxtBtnClick);
        }
        public override void Hide()
        {
            base.Hide();

            nxtBtn.onClick.RemoveListener(OnNxtBtnClick);
        }
        public override void Disable()
        {
            base.Disable();
        }
        public override void Redraw()
        {
            base.Redraw();
        }
        #endregion

        #region STATIC_FUNCTIONS
        #endregion

        #region PUBLIC_FUNCTIONS
        #endregion

        #region PRIVATE_FUNCTIONS
        private void OnNxtBtnClick()
        {
            ViewController.Instance.ChangeView(ScreenName.GamePlay);
            LevelManager.Instance.NextLevel();
            GameEvents.OnGameStart?.Invoke();
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