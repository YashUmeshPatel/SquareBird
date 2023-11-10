using UnityEngine;
using ShonEagle.Tools.UI;
using Screen = ShonEagle.Tools.UI.Screen;
using Yudiz.SquareBird.Utility;
using Yudiz.SquareBird.Manager;
using UnityEngine.UI;
using System;

namespace Yudiz.SquareBird.UI
{
    public class GamePlayScreen : Screen
    {
        #region PUBLIC_VARS
        #endregion

        #region PRIVATE_VARS
        [SerializeField] private Slider levelProgress;
        [SerializeField] private TMPro.TMP_Text scoreText;
        private float newLevelProgress;
        #endregion

        #region UNITY_CALLBACKS
        private void OnEnable()
        {
            GameEvents.OnLevelProgress += UpdateGameProgress;
            GameEvents.OnUpdateScore += UpdateScore;
        }

        private void OnDisable()
        {
            GameEvents.OnLevelProgress -= UpdateGameProgress;
            GameEvents.OnUpdateScore -= UpdateScore;
        }

        private void Update()
        {
            levelProgress.value = newLevelProgress;
        }
        #endregion

        #region UI_CALLBACKS
        public override void Show()
        {
            base.Show();
            GameEvents.OnEnableBirdControls();
            GameEvents.OnGameStart?.Invoke();
        }
        public override void Hide()
        {
            base.Hide();
            GameEvents.OnDisableBirdControls();            
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
        private void UpdateScore(int score)
        {
            scoreText.text = score.ToString();
        }

        private void UpdateGameProgress(float startPoint, float endPoint, float levelXPosition)
        {
            newLevelProgress = GameManager.Map(levelXPosition, startPoint, -endPoint, 0, 1);
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