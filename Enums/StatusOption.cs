namespace Groep5_Van_Der_Lelie_Api.Enums
{
    public class StatusOption : Enumeration
    {
        public static StatusOption FINISHED = new(1, "Afgehandeld");
        public static StatusOption UNFINISHED = new(2, "Niet afgehandeld");

        public StatusOption(int id, string value) : base(id, value)
        {
        }

    }
}
