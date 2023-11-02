using UnityEngine;

namespace Yudiz.SquareBird.CoreGamePlay
{
    public class EndZone : MonoBehaviour
    {
        #region PUBLIC_VARS
        #endregion

        #region PRIVATE_VARS
        private const string Square = "Square";
        #endregion

        #region UNITY_CALLBACKS        
        private void OnCollisionEnter2D(Collision2D collision)
        {
            Debug.Log("Collision: " + collision.gameObject.name);
            if (collision.gameObject.CompareTag(Square))
            {
                collision.gameObject.SetActive(false);
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