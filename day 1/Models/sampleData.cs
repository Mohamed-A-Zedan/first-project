namespace day_1.Models
{
    public static class sampleData
    {
        private static List<register> registers= new List<register>();
        public static List <register> Registers { get => registers; } 
        public static void AddRegister(register register) { registers.Add(register); }
        public static void RemoveAtendee(register register) { registers.Remove(register); }

    }
}
