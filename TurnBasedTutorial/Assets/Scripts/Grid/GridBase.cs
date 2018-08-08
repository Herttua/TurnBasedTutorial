using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TurnBased
{
    public class GridBase : MonoBehaviour
    {
        public int sizeX = 32;
        public int sizeY = 2;
        public int sizeZ = 32;
        public float scaleZX = 1;
        public float scaleY = 2.3f;

        public bool debugNode = true;
        public Material debugMaterial;

        void Start()
        {
            
        }

        public void InitPhase()
        {

        }

        void Check()
        {
            s
        }
    }

    [System.Serializable]
    public class YLevels
    {
        public int y;
        public GameObject nodeParent;
        public GameObject collisionObj;
    }
}