using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;


using Debug = UnityEngine.Debug;
using Random = UnityEngine.Random;

public class GameController : MonoBehaviour
{
    private int num;
   // private int guessNumber;

    private int countGuess;

    [SerializeField]
    private GameObject btn;

    [SerializeField]
    private InputField input;

    [SerializeField]
    private Text text;

    void Awake()
    {
          input = GameObject.Find("InputField").GetComponent<InputField>();
        num = Random.Range(0, 100);
        text.text = " Guess A Number Between 0 and 100 ";
    }
   public void GetInput(string guess)
    {
        CompareGuesses(int.Parse(guess));
        input.text = "";
        countGuess++;
    }

    void CompareGuesses(int guess)
    {
        if(guess == num)
        {
            text.text = "You Guessed Correctly The Number was " + guess + " It took you "+ countGuess + " Guessess. " + "Do you want to Play again?" ;
            btn.SetActive(true);
        }
        else if(guess < num)
        {
            text.text = "You Number is less than my Number. Please try again! ";

        }
        else if (guess > num)
        {
            text.text = "You Number is greater than my Number. Please try again! ";
        }


    }

    public void PlayAgain()
    {
        num = Random.Range(0, 100);
        text.text = " Guess A Number Between 0 and 100 ";
        countGuess = 0;
        btn.SetActive(false);

    }
}
