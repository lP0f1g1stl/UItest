using UnityEngine;

[CreateAssetMenu(fileName = "NewAnimationData", menuName = "AnimationData")]
public class AnimationData : ScriptableObject
{
    [Header("Main")]
    [SerializeField] private float _fadeDuration = 1f;
    [Header("MainButton")]
    [SerializeField] private float _animationDelay = 1f;
    [SerializeField] private float _scaleMultiplier = 1.1f;
    [Header("Toggle")]
    [SerializeField] private float _toggleDelay = 1f;
    [SerializeField] private float _position = 30f;

    public float FadeDuration => _fadeDuration;
    public float AnimationDelay => _animationDelay;
    public float ScaleMultiplier => _scaleMultiplier;
    public float ToggleDelay => _toggleDelay;
    public float Position => _position;
}
