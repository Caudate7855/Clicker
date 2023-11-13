using UnityEngine;

public class BackgroundChanger : MonoBehaviour
{
    private int _arrayIndex;
    private int _startedIndex = 1;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Sprite[] _sprites;

    private void Start()
    {
        _arrayIndex = _startedIndex;
    }

    public void ChangeBackgroundSprite()
    {
        _spriteRenderer.sprite = _sprites[_arrayIndex];

        if (_sprites.Length-1 == _arrayIndex)
        {
            _arrayIndex = 1;
        }

        _arrayIndex++;
    }
}
