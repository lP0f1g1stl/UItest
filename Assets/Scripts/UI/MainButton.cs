using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System;

public class MainButton : MonoBehaviour
{
    private AnimationData _animationData;

    private Button _button;

    public event Action OnAnimationComplete;

    public Button Button => _button;
    public void Init(AnimationData animationData)
    {
        _button = GetComponent<Button>();
        _animationData = animationData;
        _button.onClick.AddListener(OnClick);
        SetDefault();
    }
    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnClick);
    }
    private void OnClick()
    {
        transform.DOScale(_animationData.ScaleMultiplier, _animationData.AnimationDelay)
            .SetEase(Ease.OutElastic)
            .OnComplete(() => OnAnimationComplete?.Invoke());
    }
    public void SetDefault()
    {
        transform.localScale = Vector3.one;
    }

}
