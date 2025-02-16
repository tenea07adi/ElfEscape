using TMPro;
using UnityEngine;

public class PlayerAlliveWorldStateStrategy : BaseWorldStateStrategy
{
    [SerializeField]
    private GameObject ScorePanel;

    [SerializeField]
    private TextMeshProUGUI ScoreText;

    public override bool ShouldEnter()
    {
        return false;
    }

    public override bool ShouldExit()
    {
        return true;
    }

    public override void InitLogic()
    {
        ScorePanel.SetActive(true);
    }

    public override void MainLogic()
    {
        UpdateScore();
    }

    public override void ExitLogic()
    {
        ScorePanel.SetActive(false);
    }

    private void UpdateScore()
    {
        int fullTimeInSeconds = TimerController.instance.GetCurrentTimeInSeconds(); ;

        int minutes = fullTimeInSeconds / 60;
        int seconds = fullTimeInSeconds % 60;

        string minutesText = minutes < 10 ? $"0{minutes}" : minutes.ToString();
        string secondsText = seconds < 10 ? $"0{seconds}" : seconds.ToString();

        ScoreText.SetText($"{minutesText}:{secondsText}");
    }
}
