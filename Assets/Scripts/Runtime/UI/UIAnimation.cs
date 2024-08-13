using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using DG.Tweening;
using Unity.VisualScripting;

public class UIAnimation : BaseButton
{
    [SerializeField] GameObject panel;
    [SerializeField] RectTransform panelRect;
    [SerializeField] float topPosY, middlePosY;
    [SerializeField] float tweenDuration;

   
    public void OpenMenu()
    {
        panel.SetActive(true);
        PanelIntro();
    }

    public void CloseMenu()
    {
        PanelOuttro();
        panel.SetActive(false);
        
    }

    void PanelIntro()
    {
        panelRect.DOAnchorPosY(middlePosY, tweenDuration);
    }

    void PanelOuttro()
    {
        panelRect.DOAnchorPosY(topPosY, tweenDuration);
    }

    protected override void OnClick()
    {
        OpenMenu();
    }
}
