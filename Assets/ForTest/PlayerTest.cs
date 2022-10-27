using System;
using System.Collections;
using System.Collections.Generic;
using BH_Player.InputHandle;
using Mirror;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class PlayerTest : NetworkBehaviour
{
    public Rigidbody rigidbody;
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        if(hasAuthority) CommandTest.Instance.SetRealizer(this);
    }
   
    
    




}
