﻿namespace Common.Data
{
    public class InjectorState
    {
        public bool InjectMaterialColor { get; set; } = true;
        public bool InjectMaterialColorOverlayButton { get; set; } = true;
        public bool InjectOnion { get; set; } = true;

        public bool CustomSensorRanges { get; set; } = true;
        public float MaxSensorTemperature { get; set; } = 1273.15f;
        public float MaxGasSensorPressure { get; set; } = 25;
        public float MaxLiquidSensorPressure { get; set; } = 10000;

        public bool EnableDraggableGUI { get; set; } = true;
        public bool EnableImprovedOxygenOverlay { get; set; } = true;

        public bool FixLogicBridges { get; set; } = true;
    }
}
