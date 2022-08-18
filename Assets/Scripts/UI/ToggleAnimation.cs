using UnityEngine;
using DG.Tweening;

public class ToggleAnimation : MonoBehaviour
{
    [SerializeField] private GameObject greenToggle;
    [SerializeField] private GameObject redToggle;

    public AnimationData AnimationData { get; set; }

    public bool IsActive { get; set; } // затычка.
    public bool IsBusy { get; set;}
    public void Switch(int sign)
    {
        IsBusy = true;
        transform.DOLocalMoveX(AnimationData.Position * sign, AnimationData.ToggleDelay).OnComplete(() => 
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
