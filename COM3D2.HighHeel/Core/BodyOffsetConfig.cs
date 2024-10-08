namespace COM3D2.HighHeel.Core {
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class BodyOffsetConfig {
        public float DefaultBodyOffset { get; set; }
        public float DefaultManBodyOffset { get; set; }
        public Dictionary<int, float> SceneSpecificOffsets { get; set; }
        public Dictionary<int, float> SceneSpecificManOffsets { get; set; }

        public BodyOffsetConfig() {
            SceneSpecificOffsets = new Dictionary<int, float>();
            DefaultBodyOffset = 0.04f;
            DefaultManBodyOffset = 0f;
        }

        public float GetBodyOffsetForScene(int sceneIndex) {
            if (SceneSpecificOffsets.TryGetValue(sceneIndex, out float offset)) {
                return offset;
            }
            return DefaultBodyOffset;
        }

        public float GetManBodyOffsetForScene(int sceneIndex) {
            if (SceneSpecificManOffsets.TryGetValue(sceneIndex, out float offset)) {
                return offset;
            }
            return DefaultManBodyOffset;
        }

    }
}
