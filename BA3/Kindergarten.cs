namespace BA3
{
    public class Kindergarten
    {
        public string Id { get; set; }
        public string SchoolName { get; set; }
        public string TypeId { get; set; }
        public string TypeLabel { get; set; }
        public string LanId { get; set; }
        public string LanLabel { get; set; }
        public int ChildCount { get; set; }
        public int FreeSpace { get; set; }

        internal static Kindergarten ParseFromCsv(string line)
        {
            var columns = line.Split(';');
            return new Kindergarten
            {
                Id = columns[0],
                SchoolName = columns[1],
                TypeId = columns[2],
                TypeLabel = columns[3],
                LanId = columns[4],
                LanLabel = columns[5],
                ChildCount = int.Parse(columns[6]),
                FreeSpace = int.Parse(columns[7])
            };
        }
    }
}
