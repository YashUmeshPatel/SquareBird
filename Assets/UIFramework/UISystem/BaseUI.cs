﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
namespace ShonEagle.Tools.UI
{

    public class BaseUI : MonoBehaviour
    {
        [HideInInspector]
        public GameObject content;
        [HideInInspector]
        public Canvas canvas;
        protected UIAnimator uiAnimator;
        protected UIAnimation uiAnimation;
        [HideInInspector]
        public CanvasGroup canvasGroup;
        public bool isActive { get; private set; }

        public virtual void Awake()
        {
            content = transform.GetChild(0).gameObject;
            canvas = GetComponent<Canvas>();
            canvasGroup = content.GetComponent<CanvasGroup>();

            uiAnimator = GetComponent<UIAnimator>();
            uiAnimation = GetComponent<UIAnimation>();
        }
        public virtual void Disable()
        {
            canvas.enabled = false;
            isActive = false;
        }//screws with the joysticks because apparently they scale (what?)// content.SetActive(false);
        public virtual void Enable()
        {

            canvas.enabled = true;//screws with the joysticks because apparently they scale (what?)// content.SetActive(true);
            isActive = true;
        }


        public virtual void Show()
        {

            if (isActive)
                return;

            canvasGroup.interactable = true;
            if (uiAnimator)
            {
                uiAnimator.StopHide();
                uiAnimator.StartShow();
                isActive = true;
            }
            else
            {
                Enable();
                isActive = true;
            }
            Redraw();
        }
        public virtual void Hide()
        {
            if (!isActive)
                return;
            canvasGroup.interactable = false;
            if (uiAnimator)
            {
                uiAnimator.StopShow();
                uiAnimator.StartHide();
                isActive = false;
            }
            else
            {
                Disable();
                isActive = false;
            }
        }
        public virtual void Redraw()
        {
        }
    }
}