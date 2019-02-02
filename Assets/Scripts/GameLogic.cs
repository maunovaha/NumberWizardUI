using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameLogic : MonoBehaviour
{
    [SerializeField]
    private int min = 1;

    [SerializeField]
    private int max = 1000;

    [SerializeField]
    private TextMeshProUGUI guessText;

    private int guess;

    public void OnPressHigher()
    {
        min = guess;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess;
        NextGuess();
    }
    
    private void Start()
    {
        NextGuess();
    }

    private void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }
}
