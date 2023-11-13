using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Player _player;

    private void Start()
    {
        _slider.maxValue = _player.NextLevelStep;
    }

    private void OnEnable()
    {
        _player.ScoreChanged += OnScoreChanged;
    }

    private void OnDisable()
    {
        _player.ScoreChanged -= OnScoreChanged;
    }

    private void OnScoreChanged(int score)
    {
        _slider.value = score;
        
        if (_slider.value >= _slider.maxValue)
        {
            _slider.maxValue = _player.NextLevelStep;
        }
    }
}