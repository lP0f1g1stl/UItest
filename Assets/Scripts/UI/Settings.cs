using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [Header("AnimationSettings")]
    [SerializeField] private AnimationData _animationData;
    [Space]
    [Header("Buttons")]
    [SerializeField] private MainButton _mainButton;
    [Space]
    [SerializeField] private Button[] _buttons;
    [Space]
    [Header("Toggles")]
    [SerializeField] private Toggle[] _toggles;
    [Space]

    private CanvasGroup _group;

    public Toggle[] Toggles => _toggles;
    public Button[] Buttons => _buttons;

    private void Awake()
    {
        _group = GetComponent<CanvasGroup>();
        foreach(Toggle tg in _toggles) 
        {
            tg.Animation.AnimationData = _animationData;
        }
    }
    private void OnEnable()
    {
        _mainButton.Init(_animationData);
        _mainButton.Button.onClick.AddListener(OnClick);
        _mainButton.OnAnimationComplete += Close;
        SetDefault();
    }
    private void OnDisable()
    {
        _mainButton.Button.onClick.RemoveListener(OnClick);
        _mainButton.OnAnimationComplete -= Close;
    }

    private void OnClick()
    {
        _group.interactable = false;
    }
    private void Close() 
    {
        _group.DOFade(0, _animationData.FadeDuration).OnComplete(() => gameObject.SetActive(false));
    }
    private void SetDefault() 
    {
        _group.alpha = 1;
        _group.interactable = true;
    }
}
