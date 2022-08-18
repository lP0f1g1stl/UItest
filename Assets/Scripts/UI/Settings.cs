using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [Header("AnimationSettings")]
    [SerializeField] private float _fadeDuration = 1f;
    [Space] 
    [SerializeField] private MainButton _mainButton;
    [SerializeField] private Button _privacy;
    [SerializeField] private Button _rules;
    [Space]
    [SerializeField] private Toggle[] _toggles;

    private CanvasGroup _group;

    private void Awake()
    {
        _group = GetComponent<CanvasGroup>();
    }
    private void OnEnable()
    {
        _mainButton.OnMainButtonClick += OnClick;
        _mainButton.OnAnimationComplete += Close;
        _privacy.onClick.AddListener(Test);
        _rules.onClick.AddListener(Test);
        SetDefault();
    }
    private void OnDisable()
    {
        _mainButton.OnMainButtonClick -= OnClick;
        _mainButton.OnAnimationComplete -= Close;
        _privacy.onClick.RemoveListener(Test);
        _rules.onClick.RemoveListener(Test);
    }

    private void OnClick()
    {
        for (int i = 0; i < _toggles.Length; i++)
        {
            _toggles[i].IsBlocked = true;
        }
    }
    private void Close() 
    {
        _group.DOFade(0, _fadeDuration).OnComplete(() => gameObject.SetActive(false));
    }
    private void SetDefault() 
    {
        _group.alpha = 1;
    }
    private void Test() 
    {
        Debug.Log("Click");
    }
}
