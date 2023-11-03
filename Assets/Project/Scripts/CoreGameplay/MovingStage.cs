using System.Collections;
using UnityEngine;
using Yudiz.SquareBird.Utility;

namespace Yudiz.SquareBird.CoreGamePlay
{
    public class MovingStage : MonoBehaviour
    {
        #region PUBLIC_VARS
        #endregion

        #region PRIVATE_VARS                
        [SerializeField] private float moveSpeed = 5f;
        [SerializeField] private float endZoneSpeed = 3f;
        [SerializeField] private float movementStopCooldown = 4f;
        #endregion

        #region UNITY_CALLBACKS
        private void OnEnable()
        {
            GameEvents.OnGameOver += StopMoving;
            GameEvents.OnEndZoneReached += StopMoving;
            GameEvents.OnEndZoneReached += SlowDownSpeed;
        }

        private void OnDisable()
        {
            GameEvents.OnGameOver -= StopMoving;
            GameEvents.OnEndZoneReached -= StopMoving;
            GameEvents.OnEndZoneReached -= SlowDownSpeed;
        }

        private void Start()
        {
            StartMoving();
            //StartCoroutine(nameof(MoveStageCorutine));
        }
        #endregion

        #region STATIC_FUNCTIONS
        #endregion

        #region PUBLIC_FUNCTIONS        
        public void StartMoving()
        {
            StartCoroutine(nameof(MoveStageCoroutine), moveSpeed);
        }

        [EasyButtons.Button]
        public void StopMoving()
        {
            StopCoroutine(nameof(MoveStageCoroutine));
        }

        public void SlowDownSpeed()
        {
            StartCoroutine(nameof(MoveStageCoroutine), endZoneSpeed);
            StartCoroutine(nameof(StopMovingAfterCoolDown));
        }
        #endregion

        #region PRIVATE_FUNCTIONS        
        #endregion

        #region CO-ROUTINES        
        private IEnumerator MoveStageCoroutine(float moveSpeed)
        {
            while (true)
            {
                transform.Translate(moveSpeed * Time.deltaTime * Vector3.left);
                yield return null;
            }
        }

        private IEnumerator StopMovingAfterCoolDown()
        {
            yield return new WaitForSeconds(movementStopCooldown);
            StopMoving();
        }
        #endregion

        #region EVENT_HANDLERS
        #endregion

        #region UI_CALLBACKS
        #endregion
    }
}