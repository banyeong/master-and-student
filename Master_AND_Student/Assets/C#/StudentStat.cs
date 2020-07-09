using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentStat : MonoBehaviour
{
    public static StudentStat instance;

    public int MslStr;//근력
    public int currentMslStr;

    public int MoralStr;//도력
    public int currentMoralStr;

    public int Wealth;//재력
    public int currentWealth;

    public int Favorability;//호감도
    public int cureentFavorability;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
