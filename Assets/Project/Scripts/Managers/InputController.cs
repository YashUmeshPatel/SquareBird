using System;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using Yudiz.SquareBird.Utility;

namespace Yudiz.SquareBird.Manager
{
    public class InputController : MonoBehaviour
    {
        #region PUBLIC_VARS
        #endregion

        #region PRIVATE_VARS
        private GameControls gameControls;

        private bool isInputPressed;
        private bool isCooldownFinished;

        private float screenTapWaitTime = 0.2f;
        #endregion

        #region UNITY_CALLBACKS
        private void Awake()
        {
            gameControls = new();
        }

        private void OnEnable()
        {
            GameEvents.OnGameOver += DisableBirdControls;
            GameEvents.OnEnableBirdControls += EnableBirdControls;
            GameEvents.OnDisableBirdControls += DisableBirdControls;
            

            //gameControls.Bird.Enable();            
            gameControls.Bird.ScreenTap.performed += ScreenTap;    
            gameControls.Bird.ScreenTap.canceled += ScreenTap;            
        }

        private void OnDisable()
        {
            GameEvents.OnGameOver -= DisableBirdControls;
            GameEvents.OnEnableBirdControls -= EnableBirdControls;
            GameEvents.OnDisableBirdControls -= DisableBirdControls;

            gameControls.Bird.Disable();            
            gameControls.Bird.ScreenTap.performed -= ScreenTap;
            gameControls.Bird.ScreenTap.canceled -= ScreenTap;
        }

        private void Update()
        {
            if (isInputPressed && !isCooldownFinished)
            {
                StartCoroutine(nameof(ScreenTapCooldown));                
            }
        }
        #endregion

        #region STATIC_FUNCTIONS
        #endregion

        #region PUBLIC_FUNCTIONS
        public void DisableBirdControls()
        {
            gameControls.Bird.Disable();
        }

        public void EnableBirdControls()
        {
            gameControls.Bird.Enable();
        }
        #endregion

        #region PRIVATE_FUNCTIONS


        private void ScreenTap(InputAction.CallbackContext context)
        {
            if(context.phase == InputActionPhase.Performed)
            {
                isInputPressed = true;
            }
            else
            {
                isInputPressed = false;
            }
        }

        private IEnumerator ScreenTapCooldown()
        {
            isCooldownFinished = true;
            GameEvents.OnScreenTapped?.Invoke();
            yield return new WaitForSeconds(screenTapWaitTime);
            isCooldownFinished = false;
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