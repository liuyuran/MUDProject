namespace MUDProject.core.player
{
    public class Name
    {
        public string FamilyName;
        public string PersonName;
        public string SafeName;
        public override string ToString()
        {
            return $"{FamilyName}{PersonName}";
        }
    }
}