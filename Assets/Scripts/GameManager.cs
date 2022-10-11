using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject cubePrefab;
    [SerializeField] public float delay = 1f;
    [SerializeField] public Vector3 target;
    [SerializeField] public float speed = 3f;
    
    private void Start()
    {
        StartCoroutine(CubeSpawnDelay());
    }

    private IEnumerator CubeSpawnDelay()
    {
        while (true)
        {
            Instantiate(cubePrefab, Vector3.zero, Quaternion.identity);
            yield return new WaitForSeconds(delay);
        }
    }
}
