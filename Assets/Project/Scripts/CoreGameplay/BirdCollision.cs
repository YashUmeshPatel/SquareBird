using UnityEngine;
using Yudiz.SquareBird.Utility;

namespace Yudiz.SquareBird.CoreGamePlay
{
    public class BirdCollision : MonoBehaviour
    {
        #region PUBLIC_VARS
        #endregion

        #region PRIVATE_VARS        
        private Bird bird;
        #endregion

        #region UNITY_CALLBACKS
        private void Start()
        {
            bird = transform.GetComponentInParent<Bird>();
            Debug.Log("Bird: " + bird.gameObject.name);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag(Constants.Stage))
            {
                GameOver();
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
            Debug.LogError("Game Over");
            //transform.parent.gameObject.SetActive(false);

            GameEvents.OnGameOver?.Invoke();

            bird.GameOverBehaviour();
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