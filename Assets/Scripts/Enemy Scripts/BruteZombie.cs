using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BruteZombie : Enemy
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        knockbackPower = 1.5f;
        knockbackDuration = 3f;
        agent.speed = speedMultiplier * UnityEngine.Random.Range(3f,4f);
    }

    public override void IncreaseHealth(int multiplier) {
        base.maxHp = Convert.ToInt32(base.maxHp+(12*multiplier));
        base.hp = base.maxHp;
    }

    public override void DealDamage(Player player) {
        player.ReduceHp(75f);
    }
}
