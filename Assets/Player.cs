using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IHitable
{
    [SerializeField]
    private float maxHp;

    [SerializeField]
    private float curHp;
    public float CurHp
    {
        set
        {
            curHp = value;
            ReactionWhenGotdmg();
            if (curHp <= 0)
            {

            }
            
        }
    }

    public void ReactionWhenGotdmg()
    {
        
    }
}
