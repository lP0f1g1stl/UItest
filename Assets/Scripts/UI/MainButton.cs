using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System;

public class MainButton : MonoBehaviour
{
    [Header("AnimationSettings")]
    [SerializeField] private float _animationDelay = 1f;
    [SerializeField] private float _scaleMultiplier = 1.1f;

    private Button _button;

    public Action OnMainButtonClick;
    public Action OnAnimationComplete;
    private void Awake()
    {
        _button = GetComponent<Button>();
    }
    private void OnEnable()
    {
        _button.onClick.AddListener(OnClick);
        SetDefault();
    }
    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnClick);
    }
    private void OnClick()
    {
        _button.enabled = false;
        OnMainButtonClick?.Invoke();
        transform.DOScale(_scaleMultiplier, _animationDelay)
            .SetEase(Ease.OutElastic)
            .OnComplete(() => OnAnimationComplete?.Invoke());
    }
    public void SetDefault()
    {
        _button.enabled = true;
        transform.localScale = Vector3.one;
    }

}
