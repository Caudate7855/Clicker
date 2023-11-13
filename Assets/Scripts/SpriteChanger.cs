using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    private int _arrayIndex;
    private int _startedIndex = 1;
    [SerializeField] private Sprite[] _sprites;
    [SerializeField] private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _arrayIndex = _startedIndex;
    }

    public void ChangeCharacterSprite()
    {
        _spriteRenderer.sprite = _sprites[_arrayIndex];

        if (_sprites.Length-1 == _arrayIndex)
        {
            _arrayIndex = 1;
        }
        
        _arrayIndex++;
        Destroy(GetComponent<PolygonCollider2D>());
        gameObject.AddComponent<PolygonCollider2D>();
    }
}
