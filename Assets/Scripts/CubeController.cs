using UnityEngine;

public class CubeController : MonoBehaviour
{
    private GameManager _game;
    private Vector3 _currentTarget;
    private float _currentSpeed;
    

    private void Awake()
    {
        _game = FindObjectOfType<GameManager>();
    }

    private void Start()
    {
        _currentTarget = _game.target;
        _currentSpeed = _game.speed;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _currentTarget, _currentSpeed * Time.deltaTime);
        if (transform.position == _currentTarget)
        {
            Destroy(gameObject);
        }
    }
}
