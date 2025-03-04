﻿using System.Collections.Generic;

namespace COM3D2.Highheel.Plugin.Core
{
    public class ShoeConfig
    {
        public enum ShoeConfigParameter
        {
            BodyOffset,
            ManBodyOffset,
            PerSceneBodyOffsets,
            PerSceneManBodyOffsets,
            FootLAngle,
            FootLMax,
            ToeL0AngleX,
            ToeL01AngleX,
            ToeL1AngleX,
            ToeL11AngleX,
            ToeL2AngleX,
            ToeL21AngleX,
            ToeL0AngleY,
            ToeL01AngleY,
            ToeL1AngleY,
            ToeL11AngleY,
            ToeL2AngleY,
            ToeL21AngleY,
            ToeL0AngleZ,
            ToeL01AngleZ,
            ToeL1AngleZ,
            ToeL11AngleZ,
            ToeL2AngleZ,
            ToeL21AngleZ,
            FootRAngle,
            FootRMax,
            ToeR0AngleX,
            ToeR01AngleX,
            ToeR1AngleX,
            ToeR11AngleX,
            ToeR2AngleX,
            ToeR21AngleX,
            ToeR0AngleY,
            ToeR01AngleY,
            ToeR1AngleY,
            ToeR11AngleY,
            ToeR2AngleY,
            ToeR21AngleY,
            ToeR0AngleZ,
            ToeR01AngleZ,
            ToeR1AngleZ,
            ToeR11AngleZ,
            ToeR2AngleZ,
            ToeR21AngleZ
        }
        public float BodyOffset { get; set; } = 0.04f; // Experience-based values
        public float ManBodyOffset { get; set; } = 0f;
        public Dictionary<string , float> PerSceneBodyOffsets { get; set; } = new();
        public Dictionary<string , float> PerSceneManBodyOffsets { get; set; } = new();
        public float FootLAngle { get; set; }
        public float FootLMax { get; set; } = 55f;

        //Individual Toes L XYZ - Start
        public float ToeL0AngleX { get; set; }
        public float ToeL0AngleY { get; set; }
        public float ToeL0AngleZ { get; set; }
        public float ToeL01AngleX { get; set; }
        public float ToeL01AngleY { get; set; }
        public float ToeL01AngleZ { get; set; }
        public float ToeL1AngleX { get; set; }
        public float ToeL1AngleY { get; set; }
        public float ToeL1AngleZ { get; set; }
        public float ToeL11AngleX { get; set; }
        public float ToeL11AngleY { get; set; }
        public float ToeL11AngleZ { get; set; }
        public float ToeL2AngleX { get; set; }
        public float ToeL2AngleY { get; set; }
        public float ToeL2AngleZ { get; set; }
        public float ToeL21AngleX { get; set; }
        public float ToeL21AngleY { get; set; }

        public float ToeL21AngleZ { get; set; }
        //Individual Toes L XYZ - End




        public float FootRAngle { get; set; }
        public float FootRMax { get; set; } = 55f;

        //Individual Toes R XYZ - Start
        public float ToeR0AngleX { get; set; }
        public float ToeR0AngleY { get; set; }
        public float ToeR0AngleZ { get; set; }
        public float ToeR01AngleX { get; set; }
        public float ToeR01AngleY { get; set; }
        public float ToeR01AngleZ { get; set; }
        public float ToeR1AngleX { get; set; }
        public float ToeR1AngleY { get; set; }
        public float ToeR1AngleZ { get; set; }
        public float ToeR11AngleX { get; set; }
        public float ToeR11AngleY { get; set; }
        public float ToeR11AngleZ { get; set; }
        public float ToeR2AngleX { get; set; }
        public float ToeR2AngleY { get; set; }
        public float ToeR2AngleZ { get; set; }
        public float ToeR21AngleX { get; set; }
        public float ToeR21AngleY { get; set; }
        public float ToeR21AngleZ { get; set; }
        //Individual Toes R XYZ - End


        public void Deconstruct(
            out float bodyOffset,
            out float manBodyOffset,
            out Dictionary<string, float> perSceneBodyOffsets,
            out Dictionary<string, float> perSceneManBodyOffsets,
            out float footLAngle, out float footLMax,
            out float toeL0AngleX, out float toeL01AngleX, out float toeL1AngleX, out float toeL11AngleX,
            out float toeL2AngleX, out float toeL21AngleX,
            out float toeL0AngleY, out float toeL01AngleY, out float toeL1AngleY, out float toeL11AngleY,
            out float toeL2AngleY, out float toeL21AngleY,
            out float toeL0AngleZ, out float toeL01AngleZ, out float toeL1AngleZ, out float toeL11AngleZ,
            out float toeL2AngleZ, out float toeL21AngleZ,
            out float footRAngle, out float footRMax,
            out float toeR0AngleX, out float toeR01AngleX, out float toeR1AngleX, out float toeR11AngleX,
            out float toeR2AngleX, out float toeR21AngleX,
            out float toeR0AngleY, out float toeR01AngleY, out float toeR1AngleY, out float toeR11AngleY,
            out float toeR2AngleY, out float toeR21AngleY,
            out float toeR0AngleZ, out float toeR01AngleZ, out float toeR1AngleZ, out float toeR11AngleZ,
            out float toeR2AngleZ, out float toeR21AngleZ
        )
        {
            bodyOffset = BodyOffset;
            manBodyOffset = ManBodyOffset;
            perSceneBodyOffsets = PerSceneBodyOffsets;
            perSceneManBodyOffsets = PerSceneManBodyOffsets;
            
            footLAngle = FootLAngle;
            footLMax = FootLMax;

            toeL0AngleX = ToeL0AngleX;
            toeL0AngleY = ToeL0AngleY;
            toeL0AngleZ = ToeL0AngleZ;

            toeL01AngleX = ToeL01AngleX;
            toeL01AngleY = ToeL01AngleY;
            toeL01AngleZ = ToeL01AngleZ;

            toeL1AngleX = ToeL1AngleX;
            toeL1AngleY = ToeL1AngleY;
            toeL1AngleZ = ToeL1AngleZ;

            toeL11AngleX = ToeL11AngleX;
            toeL11AngleY = ToeL11AngleY;
            toeL11AngleZ = ToeL11AngleZ;

            toeL2AngleX = ToeL2AngleX;
            toeL2AngleY = ToeL2AngleY;
            toeL2AngleZ = ToeL2AngleZ;

            toeL21AngleX = ToeL21AngleX;
            toeL21AngleY = ToeL21AngleY;
            toeL21AngleZ = ToeL21AngleZ;




            footRAngle = FootRAngle;
            footRMax = FootRMax;

            toeR0AngleX = ToeR0AngleX;
            toeR0AngleY = ToeR0AngleY;
            toeR0AngleZ = ToeR0AngleZ;

            toeR01AngleX = ToeR01AngleX;
            toeR01AngleY = ToeR01AngleY;
            toeR01AngleZ = ToeR01AngleZ;

            toeR1AngleX = ToeR1AngleX;
            toeR1AngleY = ToeR1AngleY;
            toeR1AngleZ = ToeR1AngleZ;

            toeR11AngleX = ToeR11AngleX;
            toeR11AngleY = ToeR11AngleY;
            toeR11AngleZ = ToeR11AngleZ;

            toeR2AngleX = ToeR2AngleX;
            toeR2AngleY = ToeR2AngleY;
            toeR2AngleZ = ToeR2AngleZ;

            toeR21AngleX = ToeR21AngleX;
            toeR21AngleY = ToeR21AngleY;
            toeR21AngleZ = ToeR21AngleZ;
        }
    }
}