namespace Survivalistic
{
    public class Config
    {
        public float hunger_velocity { get; set; } = 0.25f;
        public float thirst_velocity { get; set; } = 0.25f;

        public float global_scale { get; set; } = 3;

        public string bars_position { get; set; } = "bottom-right";
        public int bars_custom_x { get; set; } = 0;
        public int bars_custom_y { get; set; } = 0;
    }
}
