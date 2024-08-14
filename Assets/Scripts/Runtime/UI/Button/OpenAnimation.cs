using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using DG.Tweening;
using Unity.VisualScripting;

public class OpenAnimation : BaseButton
{
    [SerializeField] GameObject panel;
    [SerializeField] RectTransform panelRect;
    [SerializeField] float middlePosY;
    [SerializeField] float tweenDuration;

    protected override void OnClick()
    {
        OpenMenu();
    }

    public void OpenMenu()
    {
        panel.SetActive(true);
        
        PanelIntro();
    }

    void PanelIntro()
    {
        panelRect.DOAnchorPosY(middlePosY, tweenDuration);
    }

}
