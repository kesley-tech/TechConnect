namespace TechConnect
{
    public class WorkoutDTO
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public MUSCLE_GROUP_TYPE GrupoMuscular { get; set; }
        public bool FreeWorkout { get; set; }

        public enum MUSCLE_GROUP_TYPE
        {
            Torax
            , Ombro
            , Trceps
            , Biceps
            , Costas
            , Perna
            , Gluteo
            , Panturrilha
        }
    }
}
