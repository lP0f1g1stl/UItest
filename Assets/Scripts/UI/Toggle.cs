using UnityEngine;
using UnityEngine.UI;
using System;

public class Toggle : MonoBehaviour
{
    [SerializeField] private ToggleAnimation _animation;

    private Button _button;

    public event Action<bool> OnToggleClick;

    public ToggleAnimation Animation => _animation;
    private void Awake()
    {
        _button = GetComponent<Button>();
    }
    private void OnEnable()
    {
        _button.onClick.AddListener(ChangeToggle);
    }
    private void OnDisable()
    {
        _button.onClick.RemoveListener(ChangeToggle);
    }
    private void ChangeToggle() 
    {
        if (!_animation.IsBusy) 
        {
            _animation.IsActive = !_animation.IsActive;
            int sign = _animation.IsActive ? 1 : -1;
            _animation.Switch(sign);
            OnToggleClick?.Invoke(_animation.IsActive);
        }
    }
}
