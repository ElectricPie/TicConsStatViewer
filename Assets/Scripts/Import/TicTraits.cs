using System;

namespace Import
{
    [Serializable]
    public class TicTraits
    {
        public string id = "";
        public string name = "";
        public string desc = "";
        public bool hidden = false;
        public float priority = -1;
        public string color = "";
    }
}