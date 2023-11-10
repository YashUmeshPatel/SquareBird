using UnityEngine;
using ShonEagle.Tools.UI;
using Screen = ShonEagle.Tools.UI.Screen;
using UnityEngine.UI;
using Yudiz.SquareBird.Levels;

namespace Yudiz.SquareBird.UI
{
    public class MainMenuScreen : Screen
    {
        #region PUBLIC_VARS
        #endregion

        #region PRIVATE_VARS
        [SerializeField] private Button screenbtn;
        #endregion

        #region UNITY_CALLBACKS
        private void Start()
        {
            LevelManager.Instance.LoadLevel(0);
        }
        #endregion

        #region UI_CALLBACKS
        public override void Show()
        {
            base.Show();            

            screenbtn.onClick.AddListener(OnScreenBtnClicked);
        }
        public override void Hide()
        {
            base.Hide();            

            screenbtn.onClick.RemoveListener(OnScreenBtnClicked);
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
        private void OnScreenBtnClicked()
        {
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