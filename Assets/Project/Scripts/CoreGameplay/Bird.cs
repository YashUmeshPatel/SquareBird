using System;
using System.Collections.Generic;
using UnityEngine;
using Yudiz.SquareBird.Utility;

namespace Yudiz.SquareBird.CoreGamePlay
{
    public class Bird : MonoBehaviour
    {
        #region PUBLIC_VARS
        #endregion

        #region PRIVATE_VARS
        private Rigidbody2D rb2D;
        [SerializeField] private float forceAmount;
        #endregion

        #region UNITY_CALLBACKS
        private void Awake()
        {
            rb2D = GetComponent<Rigidbody2D>();
        }
        #endregion

        #region STATIC_FUNCTIONS
        #endregion

        #region PUBLIC_FUNCTIONS
        public void GameOverBehaviour()
        {
            Debug.Log("Force");
            rb2D.constraints = RigidbodyConstraints2D.None;
            rb2D.AddForce(Vector2.left * forceAmount, ForceMode2D.Impulse);
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