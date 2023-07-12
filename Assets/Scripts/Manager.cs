using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public Text Result;
    public Image AIChoice;

    public string[] Choices;
    public Sprite Rock, Paper, Scissors;

    public void Play(string myChoice)
    {
        string randomChoice = Choices[Random.Range(0, Choices.Length)];

        switch(randomChoice)
        {
            case "Rock":
                switch(myChoice)
                {
                    case "Rock":
                        Result.text = "Tie!";
                        break;

                    case "Paper":
                        Result.text = "Paper covers rock. You win!";
                        break;

                    case "Scissors":
                        Result.text = "Rock crushes scissors. You lose!";
                        break;
                    
                }

                AIChoice.sprite = Rock;
                break;

            case "Paper":
                switch (myChoice)
                {
                    case "Rock":
                        Result.text = "Paper covers rock. You lose!";
                        break;

                    case "Paper":
                        Result.text = "Tie!";
                        break;

                    case "Scissors":
                        Result.text = "Scissors cut paper. You win!";
                        break;

                }

                AIChoice.sprite = Paper;
                break;

            case "Scissors":
                switch (myChoice)
                {
                    case "Rock":
                        Result.text = "Rock destroys scissors. You win!";
                        break;

                    case "Paper":
                        Result.text = "Scissors cut paper. You lose!";
                        break;

                    case "Scissors":
                        Result.text = "Tie!";
                        break;

                }

                AIChoice.sprite = Scissors;
                break;

        }
    }
}
