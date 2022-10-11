using System.Globalization;
using TMPro;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    [SerializeField] private TMP_InputField speedText;
    [SerializeField] private TMP_InputField spawnDelay;
    [SerializeField] private TMP_InputField x;
    [SerializeField] private TMP_InputField y;
    [SerializeField] private TMP_InputField z;
    
    private GameManager _game;

    private void Awake()
    {
        _game = FindObjectOfType<GameManager>();
    }

    private void Start()
    {
        speedText.text = _game.speed.ToString(CultureInfo.CurrentCulture);
        spawnDelay.text = _game.delay.ToString(CultureInfo.CurrentCulture);
        x.text = _game.target.x.ToString(CultureInfo.CurrentCulture);
        y.text = _game.target.y.ToString(CultureInfo.CurrentCulture);
        z.text = _game.target.z.ToString(CultureInfo.CurrentCulture);
    }

    public void OnClick()
    {
        _game.speed = float.Parse(speedText.text);
        _game.delay = float.Parse(spawnDelay.text);
        _game.target.x = int.Parse(x.text);
        _game.target.y = int.Parse(y.text);
        _game.target.z = int.Parse(z.text);
    }
}
