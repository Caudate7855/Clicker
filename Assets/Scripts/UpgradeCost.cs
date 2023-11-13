using UnityEngine;
using TMPro;

public class UpgradeCost : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _upgradeCost;

    private void OnEnable()
    {
        _player.UpgradeCostChanged += OnUpgradeCostChanged;
    }

    private void OnDisable()
    {
        _player.UpgradeCostChanged -= OnUpgradeCostChanged;
    }

    private void OnUpgradeCostChanged(int cost)
    {
        _upgradeCost.text = cost.ToString();
    }
}