using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class CloseAnimation : BaseButton
{

    [SerializeField] GameObject panel;
    [SerializeField] RectTransform panelRect;
    [SerializeField] float topPosY;
    [SerializeField] float tweenDuration;

    protected override void OnClick()
    {
        CloseMenu();
    }

    public async void CloseMenu()
    {
        await PanelOuttro();
        panel.SetActive(false);
        

    }
    async Task PanelOuttro()
    {
        await panelRect.DOAnchorPosY(topPosY, tweenDuration).AsyncWaitForCompletion();
    }

}
