using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pellet
{
    protected int bonus;

    public Pellet(int bonus)
    {
        this.bonus = bonus;
    }
}
