namespace TechConnect
{
    public class BuildingWorkoutUserDTO
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string QuantityVencimento { get; set; }
        public STATUS_VENCIMENTO_USER Status { get; set; } = STATUS_VENCIMENTO_USER.Ok;

        public enum STATUS_VENCIMENTO_USER
        {
            Ok = 1,
            ProximoVencimento = 2,
            Vencido = 3
        }
    }
}
