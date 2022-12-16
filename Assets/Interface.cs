using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISightable
{
    public bool IsInAngle();
    public bool IsInRange();
}

public interface IMovement
{

}

public interface IHearable
{
    public bool IsHearable();
}

public interface IHitable
{
    public void ReactionWhenGotdmg();
}