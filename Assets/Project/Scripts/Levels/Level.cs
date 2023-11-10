using UnityEngine;
using Yudiz.SquareBird.Manager;
using Yudiz.SquareBird.Utility;

namespace Yudiz.SquareBird.Levels
{
    public class Level : MonoBehaviour
    {
        #region PUBLIC_VARS
        #endregion

        #region PRIVATE_VARS
        [SerializeField] private Transform endPointTransform;
        float endPoint;
        float startPoint;
        #endregion

        #region UNITY_CALLBACKS
        private void Start()
        {
            endPoint = endPointTransform.position.x;            
            startPoint = transform.position.x;            
        }

        private void Update()
        {
            GameEvents.OnLevelProgress?.Invoke(startPoint, endPoint, transform.position.x);
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