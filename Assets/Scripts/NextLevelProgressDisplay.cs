using UnityEngine;
using TMPro;

public class NextLevelProgressDisplay : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _nextLevelUpgradeDisplay; 

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
        _nextLevelUpgradeDisplay.text = score.ToString() + "/" + _player.NextLevelStep.ToString();
    }
}