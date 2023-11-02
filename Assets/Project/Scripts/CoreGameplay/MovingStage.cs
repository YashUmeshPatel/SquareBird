using System.Collections;
using UnityEngine;

namespace Yudiz.SquareBird.CoreGamePlay
{
    public class MovingStage : MonoBehaviour
    {
        #region PUBLIC_VARS
        #endregion

        #region PRIVATE_VARS
        private bool isGameOver;
        private float moveValue = -68;
        [SerializeField] private float desiredDuration;
        #endregion

        #region UNITY_CALLBACKS
        private void Start()
        {
            StartCoroutine(nameof(MoveStageCorutine));
        }
        #endregion

        #region STATIC_FUNCTIONS
        #endregion

        #region PUBLIC_FUNCTIONS
        #endregion

        #region PRIVATE_FUNCTIONS
        private IEnumerator MoveStageCorutine()
        {
            float initialXPosition = transform.position.x;
            float elapsedTime = 0.0f;

            while (!isGameOver) //When isGameOver is true Move Stage will Stop
            {
                elapsedTime += Time.deltaTime;
                float t = elapsedTime / desiredDuration; 

               
                float newXValue = Mathf.Lerp(initialXPosition, moveValue, t);

                transform.position = new Vector3(newXValue, transform.position.y, transform.position.z);

                
                if (t >= 1.0f)
                {
                    break; 
                }

                //if(t == 1)
                //{
                //    isGameOver = true;
                //}

                yield return null;
            }
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