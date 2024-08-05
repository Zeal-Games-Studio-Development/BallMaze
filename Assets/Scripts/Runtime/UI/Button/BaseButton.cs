using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public abstract class BaseButton : MonoBehaviour
{

    [Header("Base Button")]
    [SerializeField] protected Button button;

    protected void Start()
    {
        LoadComponents();
        AddOnClickEvent();

    }

    protected void LoadComponents()
    {
        button ??= GetComponent<Button>();
        LoadButton();
    }

    protected void LoadButton()
    {
        if (button != null) return;
            button = GetComponent<Button>();
        Debug.LogWarning(transform.name + ": LoadButton", gameObject);

    }

    protected void AddOnClickEvent()
    {
        button.onClick.AddListener(OnClick);
    }

    protected abstract void OnClick();
}
