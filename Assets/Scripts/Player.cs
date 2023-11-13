using System;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    private const int StartedScore = 0;
    private const int StartedUpgradeCost = 5;
    private const int StartedMultiplier = 1;
    
    [NonSerialized]public int _maxSliderValue;
    [SerializeField] private  float _nextLevelStep = 50;
    [SerializeField] private SpriteChanger _spriteChanger;
    [SerializeField] private BackgroundChanger _backgroundChanger;
    private int _upgradeStepMultiplier = 2;
    private int _multiplier;
    private int _score;
    private int _nextUpgradeCost = 5;
    private int _upgradeValueMultiplier = 2;
    
    public float NextLevelStep { get => _nextLevelStep; set => _nextLevelStep = value; }
    public int Score { get => _score; set => _score = value; }
    public int Multiplier { get => _multiplier; set => _multiplier = value;  }
    public int UpgradeCost {get => _nextUpgradeCost; set => _nextUpgradeCost = value; }

    public event UnityAction<int> ScoreChanged;
    public event UnityAction<int> UpgradeCostChanged;

    private void Start()
    {
        Score = StartedScore;
        Multiplier = StartedMultiplier;
        UpgradeCost = StartedUpgradeCost;
    }
    
    public void AddScore()
    {
        Score += Multiplier;
        ScoreChanged?.Invoke(Score);
        IncreaseProgress();
    }

    public void IncreaseMultiplier()
    {
        if (Score >= _nextUpgradeCost)
        {
            Score -= _nextUpgradeCost;
            Multiplier += _upgradeValueMultiplier;
            ScoreChanged?.Invoke(Score);
            _nextUpgradeCost += _nextUpgradeCost;
            UpgradeCostChanged?.Invoke(UpgradeCost);
        }
    }

    public void IncreaseProgress()
    {
        if (Score >= NextLevelStep)
        {
            _spriteChanger.ChangeCharacterSprite();
            _backgroundChanger.ChangeBackgroundSprite();
            NextLevelStep *= _upgradeStepMultiplier;
        }
    }
}
