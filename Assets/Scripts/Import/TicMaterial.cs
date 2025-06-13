using System;

namespace Import
{
    [Serializable]
    public class TicMaterial
    {
        public string id = "";
        public string color = "";
        public string name = "";
        
    }

    [Serializable]
    public class TicMaterialHead
    {
        private float durability = -1.0f;
        public float attack = -1.0f;
        public float level= -1.0f;
        public float speed= -1.0f;
        public string[] traits;
    }
}