using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SOPlayerSetup : ScriptableObject
{
    public Animator player;

    [Header("Speed")]
    public Vector2 friction = new Vector2(-.1f, 0);
    public float speed;
    public float speedRun;
    public float jumpForce;

    [Header("Animation Player")]
    public string boolRun = "Run";
    public float playerSwipeDuration = .1f;
    public string boolJump = "Jump";
    public string triggerDeath = "Die";

}
