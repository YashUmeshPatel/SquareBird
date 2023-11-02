using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ShonEagle.Tools.UI
{
    public class UIRotate : UIAnimation
    {
       
        public float finalRotation;
        RectTransform rectTransform;
        public override void Awake()
        {
            base.Awake();
            rectTransform = content.GetComponent<RectTransform>();
        }
        public override void OnAnimationStarted()
        {
            base.OnAnimationStarted();
        }

        public override void OnAnimationRunning(float animPerc)
        {
            rectTransform.localRotation = Quaternion.Euler(Vector3.forward*(finalRotation*animPerc));
            base.OnAnimationRunning(animPerc);
        }
        public override void OnAnimationEnded()
        {
            rectTransform.localRotation = Quaternion.Euler(Vector3.forward*finalRotation);
            base.OnAnimationEnded();
        }
    }
}
