using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class CommandTest : MonoBehaviour
{
   public static CommandTest Instance { get; private set; }
   public PlayerTest CommandRealizer;

   private void Awake()
   {
      Instance = this;
   }
   
   private void Update()
   {
      if (!CommandRealizer.isClient) return;
      if(Input.GetKeyDown(KeyCode.Mouse0)) TestCommand();
   }
   public void TestCommand()
   {
     Debug.Log("AA");
     CommandRealizer.rigidbody.AddForce(Vector3.up * 5, ForceMode.Impulse);
   }

   public void SetRealizer(PlayerTest test)
   {
      CommandRealizer = test;
      
   }
}
