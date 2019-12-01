using UnityEngine;

namespace AIChara {
    public abstract class CmpBase : MonoBehaviour {
        private bool baseDB;

        public CmpBase(bool _baseDB) {
            this.baseDB = _baseDB;
        }

        public abstract void SetReferenceObject();

        private DynamicBone[] dynamicBones;

        [Header("カメラ内判定用")]
        public Renderer[] rendCheckVisible;

        public int reacquire;
    }
}
