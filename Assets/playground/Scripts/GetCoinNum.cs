using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetCoinNum : MonoBehaviour
{
    [SerializeField]
    private Text _scoreText;

    // Start is called before the first frame update
    void Start()
    {
        _scoreText.text = GlobalValue.Coins.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        _scoreText.text = GlobalValue.Coins.ToString();
    }
}
