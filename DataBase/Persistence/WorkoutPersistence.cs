using System;

namespace TechConnect
{
    public class WorkoutPersistence
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int IdMuscleGroup { get; set; }
        public string MuscleGroup { get; set; }
        public bool FreeWorkout { get; set; }
        
    }
}
