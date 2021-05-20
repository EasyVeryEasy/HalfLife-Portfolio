using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    protected int hp;
    protected float moveSpeed;
    protected float jumpPower;
    protected float gravity;

    protected enum state
    {
        idle, // 이동 및 공격 상태
        hit, // 피격 상태
        die, // 사망 상태
    }

}
