using UnityEngine;
using TMPro;

public class NumberSpawner : MonoBehaviour
{
    private Player _player;
    [SerializeField] private TMP_Text _number;
    [SerializeField] private float _lifeTime = 1;

    private void Start()
    {
        _player = FindObjectOfType<Player>();
        _number.text = _player.Multiplier.ToString();
    }

    private void Update()
    {
        _lifeTime -= Time.deltaTime;
        
        if (_lifeTime <= 0)
        {
            Destroy(gameObject);
        }
    }
}