using TMPro;
using UnityEngine;

public class GameWinWorldStateStrategy : BaseWorldStateStrategy
{
    [SerializeField]
    private GameObject WinPanel;

    [SerializeField]
    private TextMeshProUGUI ScoreText;

    public override bool ShouldEnter()
    {
        return EscapeVehicleController._instance.PlayerEntered;
    }

    public override bool ShouldExit()
    {
        return false;
    }

    public override void InitLogic()
    {
        SetScore();

        WinPanel.SetActive(true);
        BasePausableGameObjectController.TogglePausableGameObjects();
    }

    public override void MainLogic()
    {
    }

    public override void ExitLogic()
    {
        WinPanel.SetActive(false);
        BasePausableGameObjectController.TogglePausableGameObjects();
    }

    private void SetScore()
    {
        int fullTimeInSeconds = TimerController.instance.GetCurrentTimeInSeconds(); ;

        int minutes = fullTimeInSeconds / 60;
        int seconds = fullTimeInSeconds % 60;

        string minutesText = minutes < 10 ? $"0{minutes}" : minutes.ToString();
        string secondsText = seconds < 10 ? $"0{seconds}" : seconds.ToString();

        ScoreText.SetText($"{minutesText}:{secondsText}");
    }
}
