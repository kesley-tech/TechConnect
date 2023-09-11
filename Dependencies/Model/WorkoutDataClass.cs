using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechConnect
{
    public class WorkoutDataClass
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public MUSCLE_GROUP_TYPE GrupoMuscular { get; set; }
        public bool FreeWorkout { get; set; }

        public enum MUSCLE_GROUP_TYPE
        {
            Torax
            ,Ombro
            ,Trceps
            ,Biceps
            ,Costas
            ,Perna
            ,Gluteo
            ,Panturrilha
        }
    }
}
