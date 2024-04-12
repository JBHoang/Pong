using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;

    public Paddle playerPaddle;
    public Paddle computerPaddle;

    public Text playerScoreText;
    public Text computerScoreText;

    private int _playerScore;
    private int _computerScore;

    public void PlayerScore()
    {
        _playerScore++;

        this.playerScoreText.text = _playerScore.ToString();
        ResetRound();
    }

    public void ComputerScore()
    {
        _computerScore++;

        this.computerScoreText.text = _computerScore.ToString();
        ResetRound();
    }

    private void ResetRound()
    {
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }

}
