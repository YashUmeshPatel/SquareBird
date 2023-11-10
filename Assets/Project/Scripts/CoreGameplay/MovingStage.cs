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
        [SerializeField] private float moveSpeed = 200;
        [SerializeField] private float endZoneSpeed = 150;        

        private Rigidbody2D rb2D;

        private bool isMoving;
        #endregion

        #region UNITY_CALLBACKS
        private void OnEnable()
        {
            GameEvents.OnGameStart += StartMoving;
            GameEvents.OnGameOver += StopMoving;
            //GameEvents.OnEndZoneReached += StopMoving;
            GameEvents.OnEndZoneReached += SlowDownSpeed;
            GameEvents.OnLevelComplete += StopMoving;
        }

        private void OnDisable()
        {
            GameEvents.OnGameStart -= StartMoving;
            GameEvents.OnGameOver -= StopMoving;
            //GameEvents.OnEndZoneReached -= StopMoving;
            GameEvents.OnEndZoneReached -= SlowDownSpeed;
            GameEvents.OnLevelComplete -= StopMoving;
        }

        private void Start()
        {
            rb2D = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            if (isMoving)
            {
                rb2D.velocity = moveSpeed * Time.deltaTime * Vector2.left;
            }
            else
            {
                rb2D.velocity = Vector2.zero;
            }
        }
        #endregion

        #region STATIC_FUNCTIONS
        #endregion

        #region PUBLIC_FUNCTIONS
        [EasyButtons.Button]
        public void StartMoving()
        {
            //StartCoroutine(nameof(MoveStageCoroutine), moveSpeed);
            isMoving = true;
        }

        [EasyButtons.Button]
        public void StopMoving()
        {
            //StopCoroutine(nameof(MoveStageCoroutine));
            isMoving = false;
        }

        [EasyButtons.Button]
        public void SlowDownSpeed()
        {
            //StartCoroutine(nameof(MoveStageCoroutine), endZoneSpeed);            
            moveSpeed = endZoneSpeed;
            //StartCoroutine(nameof(StopMovingAfterCoolDown));
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