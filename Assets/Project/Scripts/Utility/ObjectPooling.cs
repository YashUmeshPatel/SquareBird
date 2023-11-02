using System.Collections.Generic;
using UnityEngine;
using ShonEagle.Tools.Utility;

namespace Yudiz.SquareBird.Utility
{
    public class ObjectPooling : Singleton<ObjectPooling>
    {
        #region PUBLIC_VARS    
        #endregion

        #region PRIVATE_VARS
        [SerializeField] private int numberOfEachObject;
        [SerializeField] private GameObject prefabToPool;
        [SerializeField] private Transform generateSquareTransform;
        public List<GameObject> ListOfPooledObjects;        
        #endregion

        #region UNITY_CALLBACKS        
        private void Start()
        {
            CreateObjects();
        }
        #endregion

        #region STATIC_FUNCTIONS
        #endregion

        #region PUBLIC_FUNCTIONS
        #endregion

        #region PRIVATE_FUNCTIONS
        private void CreateObjects()
        {
            ListOfPooledObjects = new();
            GameObject tmp;

            for (int i = 0; i < numberOfEachObject; i++)
            {
                tmp = Instantiate(prefabToPool, generateSquareTransform);
                tmp.SetActive(false);
                ListOfPooledObjects.Add(tmp);
            }
        }
        #endregion

        #region CO-ROUTINES
        #endregion

        #region EVENT_HANDLERS
        #endregion

        #region UI_CALLBACKS
        #endregion






        public GameObject PooledObject()
        {
            for (int i = 0; i < ListOfPooledObjects.Count; i++)
            {
                if (!ListOfPooledObjects[i].activeInHierarchy)
                {
                    return ListOfPooledObjects[i];
                }
            }
            return null;
        }
    }
}
