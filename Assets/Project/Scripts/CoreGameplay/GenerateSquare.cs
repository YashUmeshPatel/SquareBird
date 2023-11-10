using UnityEngine;
using Yudiz.SquareBird.Utility;

namespace Yudiz.SquareBird.CoreGamePlay
{
    public class GenerateSquare : MonoBehaviour
    {
        #region PUBLIC_VARS
        #endregion

        #region PRIVATE_VARS
        [SerializeField] private Transform birdTransform;
        [SerializeField] private float jumpAmount = 1.2f;
        #endregion

        #region UNITY_CALLBACKS
        private void OnEnable()
        {
            GameEvents.OnScreenTapped += SpawnSquare;
        }

        private void OnDisable()
        {
            GameEvents.OnScreenTapped -= SpawnSquare;
        }
        #endregion

        #region STATIC_FUNCTIONS
        #endregion

        #region PUBLIC_FUNCTIONS
        #endregion

        #region PRIVATE_FUNCTIONS
        private void SpawnSquare()
        {
            GameObject squareClone = ObjectPooling.Instance.PooledObject();
            if (squareClone == null) { return; }
            squareClone.SetActive(true);
            squareClone.transform.position = birdTransform.position;
            birdTransform.position += Vector3.up * jumpAmount;
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