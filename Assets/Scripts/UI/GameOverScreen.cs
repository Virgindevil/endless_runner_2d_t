using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasGroup))]
public class GameOverScreen : MonoBehaviour
{   
    [SerializeField] private Button _restartButton;
    [SerializeField] private Button _exitButton;
    [SerializeField] private Player _player;

    private CanvasGroup _gameOverGroup;

    private void OnEnable()
    {
        _player.Died += OnDied;
        _restartButton.onClick.AddListener(OnRestardButtonClick);
        _exitButton.onClick.AddListener(OnExitButtonClick);

    }

    private void OnDisable()
    {
        _player.Died -= OnDied;
        _restartButton.onClick.RemoveListener(OnRestardButtonClick);
        _exitButton.onClick.RemoveListener(OnExitButtonClick);
    }


    // Start is called before the first frame update
    void Start()
    {
        _gameOverGroup = GetComponent<CanvasGroup>();
        _gameOverGroup.alpha = 0f;
    }

    private void OnDied()
    {
        _gameOverGroup.alpha = 1f;
        Time.timeScale = 0f;
    }

    private void OnRestardButtonClick()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    private void OnExitButtonClick()
    { 
        Application.Quit();
    }

}
