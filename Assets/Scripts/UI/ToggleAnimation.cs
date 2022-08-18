using UnityEngine;
using DG.Tweening;

public class ToggleAnimation : MonoBehaviour
{
    [SerializeField] private GameObject greenToggle;
    [SerializeField] private GameObject redToggle;
    [Space]
    [Header("AnimationSettings")]
    [SerializeField] private float _toggleDelay = 1f;
    [SerializeField] private float _position = 30f;

    public bool IsActive { get; set; } // затычка.
    public bool IsBusy { get; set;}
    public void Switch(int sign)
    {
        IsBusy = true;
        transform.DOLocalMoveX(_position * sign, _toggleDelay).OnComplete(() => 
        {
            ChangeToggle();
            IsBusy = false;
        });
    }
    private void ChangeToggle()
    {
        if (IsActive)
        {
            redToggle.SetActive(false);
            greenToggle.SetActive(true);
        }
        else 
        {
            redToggle.SetActive(true);
            greenToggle.SetActive(false);
        }
    }
}
