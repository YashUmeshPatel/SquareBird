using UnityEngine;
using UnityEngine.UI;
using Yudiz.SquareBird.Levels;
using ShonEagle.Tools.UI;
using Yudiz.SquareBird.Utility;
using Screen = ShonEagle.Tools.UI.Screen;

namespace Yudiz.SquareBird.UI
{
    public class GameOverScreen : Screen
    {
        #region PUBLIC_VARS
        #endregion

        #region PRIVATE_VARS
        [SerializeField] private Button reloadBtn;
        #endregion

        #region UNITY_CALLBACKS        
        #endregion

        public override void Show()
        {
            base.Show();

            reloadBtn.onClick.AddListener(OnClickReloadBtn);
        }
        public override void Hide()
        {
            base.Hide();

            reloadBtn.onClick.RemoveListener(OnClickReloadBtn);
        }
        public override void Disable()
        {
            base.Disable();
        }
        public override void Redraw()
        {
            base.Redraw();
        }

        #region STATIC_FUNCTIONS
        #endregion

        #region PUBLIC_FUNCTIONS
        #endregion

        #region PRIVATE_FUNCTIONS
        private void OnClickReloadBtn()
        {
            LevelManager.Instance.Reload();
            ObjectPooling.Instance.DisableAllSquares();
            ViewController.Instance.ChangeView(ScreenName.GamePlay);
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