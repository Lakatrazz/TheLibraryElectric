﻿using UnityEngine;
using System;
using TheLibraryElectric.Markers;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace TheLibraryElectric.Rigidbodies
{
#if UNITY_EDITOR
    [AddComponentMenu("The Library Electric/Rigidbodies/Freeze Rigidbodies")]
#endif
    public class FreezeRigidbodies : MonoBehaviour
    {
        private GameObject rigManager;
        private void Start()
        {
           
        }
        public void Freeze()
        {
            
        }
        public void Unfreeze()
        {
           
        }

        private void OnDestroy()
        {

        }
    }
}