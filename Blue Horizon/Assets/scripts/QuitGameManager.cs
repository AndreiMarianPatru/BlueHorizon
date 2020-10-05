using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGameManager : MonoBehaviour
{
    public fishArray FISHARRAY;
    public PlayerStats PLAYERSTATS;
    public SessionTimer SESSIONTIMER;

    private void OnApplicationQuit()
    {
        FISHARRAY.QuitExport();
        SESSIONTIMER.QuitExport();
        PLAYERSTATS.QuitExport();
    }

}
