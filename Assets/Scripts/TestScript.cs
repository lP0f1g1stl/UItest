using UnityEngine;

public class TestScript : MonoBehaviour
{
    [SerializeField] private Settings _settings;

    private void Start()
    {
        _settings.Buttons[(int)ButtonType.MainButton].onClick.AddListener(MainButton);
        _settings.Buttons[(int)ButtonType.RemoveADS].onClick.AddListener(RemoveADS);
        _settings.Buttons[(int)ButtonType.Recover].onClick.AddListener(Recover);
        _settings.Buttons[(int)ButtonType.Rules].onClick.AddListener(Rules);
        _settings.Buttons[(int)ButtonType.Privacy].onClick.AddListener(Privacy);
        _settings.Toggles[(int)ToggleType.Sounds].OnToggleClick += Toggle;
        _settings.Toggles[(int)ToggleType.Music].OnToggleClick += Toggle;
        _settings.Toggles[(int)ToggleType.Vibration].OnToggleClick += Toggle;
    }
    private void OnDisable()
    {
        _settings.Buttons[(int)ButtonType.MainButton].onClick.AddListener(MainButton);
        _settings.Buttons[(int)ButtonType.RemoveADS].onClick.AddListener(RemoveADS);
        _settings.Buttons[(int)ButtonType.Recover].onClick.AddListener(Recover);
        _settings.Buttons[(int)ButtonType.Rules].onClick.AddListener(Rules);
        _settings.Buttons[(int)ButtonType.Privacy].onClick.AddListener(Privacy);
        _settings.Toggles[(int)ToggleType.Sounds].OnToggleClick += Toggle;
        _settings.Toggles[(int)ToggleType.Music].OnToggleClick += Toggle;
        _settings.Toggles[(int)ToggleType.Vibration].OnToggleClick += Toggle;
    }
    private void MainButton() 
    {
        Debug.Log("Main");
    }
    private void RemoveADS()
    {
        Debug.Log("RemoveADS");
    }
    private void Recover()
    {
        Debug.Log("Recover");
    }
    private void Privacy()
    {
        Debug.Log("Privacy");
    }
    private void Rules()
    {
        Debug.Log("Rules");
    }
    private void Toggle(bool isActive) 
    {
        Debug.Log("Toggle" + isActive);
    }
}
