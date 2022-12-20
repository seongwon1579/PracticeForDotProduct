using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDetectation
{
    public bool IsInAngle();
    public bool IsInRange();
}

public interface IMovement
{

}



public interface IHitable
{
    public void ReactionWhenGotdmg();
}