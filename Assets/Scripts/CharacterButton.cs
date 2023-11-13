using Unity.Mathematics;
using UnityEngine;

public class CharacterButton : MonoBehaviour
{
    private Player _player;
    private GameObject _container;
    private Vector3 _mouseWorldPosition;
    [SerializeField] private GameObject _numberPrefab;
    
    private void Start()
    {
        _player = FindObjectOfType<Player>();
        _container = GameObject.FindGameObjectWithTag("NumberContainer");
    }

    public void OnMouseDown()
    {
        _player.AddScore();
        _mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _mouseWorldPosition.z = 0f;
        Instantiate(_numberPrefab, _mouseWorldPosition, quaternion.identity, _container.transform);
    }
}