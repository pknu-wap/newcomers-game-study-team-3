using UnityEngine;

public class LevelUP
{
    public void LevelUp(int index)
    {
        levelUpPanel.SetActive(false);
        TimeController.ResumeGame();
    }
}
