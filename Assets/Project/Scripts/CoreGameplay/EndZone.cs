using UnityEngine;
using Yudiz.SquareBird.Utility;

namespace Yudiz.SquareBird.CoreGamePlay
{
    public class EndZone : MonoBehaviour
    {
        #region PUBLIC_VARS
        #endregion

        #region PRIVATE_VARS
        
        #endregion

        #region UNITY_CALLBACKS        
        private void OnCollisionEnter2D(Collision2D collision)
        {            
            if (collision.gameObject.CompareTag(Constants.Square))
            {
                collision.gameObject.SetActive(false);
                GameOver();
            }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {            
            if(collision.GetComponent<Bird>() != null)
            {
                Debug.Log("Bird Reached EndZone");                
                GameEvents.OnEndZoneReached?.Invoke();
            }
        }
        #endregion

        #region STATIC_FUNCTIONS
        #endregion

        #region PUBLIC_FUNCTIONS
        #endregion

        #region PRIVATE_FUNCTIONS
        private void GameOver()
        {
            GameEvents.OnDisableBirdControls?.Invoke();
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