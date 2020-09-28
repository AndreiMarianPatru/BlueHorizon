using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;


[System.Serializable]
public class PlayerData 
{
    public float[] playerlocation; 
    public float[] playerrotation;
    public bool[] fishBools;
    public int[] unlockedBiomes;
    public float permanentUpgradeSpeed;
    public float permanentUpgradeCatchRate;
    public int fishOwned;

    

    public PlayerData ()
    {
        playerlocation = new float[3];
        playerlocation[0] = PlayerStats.position.x;
        playerlocation[1] = PlayerStats.position.y;
        playerlocation[2] = PlayerStats.position.z;

        playerrotation = new float[3];
        playerrotation[0] = PlayerStats.rotation.x;
        playerrotation[1] = PlayerStats.rotation.y;
        playerrotation[2] = PlayerStats.rotation.z;

     


        fishBools = new bool[147];
        fishBools = fishArray.SetAndGetFishBools();


        unlockedBiomes = new int[7];
        for (int i = 0; i < wallRemover.unlockedBiomes.Count; i++)
        {
            unlockedBiomes[i] = wallRemover.unlockedBiomes[i];
           
        }

        permanentUpgradeCatchRate = PermanentUpgrades.permanentCatchBoost;
        permanentUpgradeSpeed = PermanentUpgrades.permanentSpeedBoost;
    }
}
