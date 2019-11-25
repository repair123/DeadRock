using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public void SetReStart()
    {
        GameManager.instance.ReStartGame();
    }

    public void SetNextStage()
    {
        GameManager.instance.NextStage();
    }

    public void SetExit()
    {
        GameManager.instance.Exit();
    }
}
