namespace Lab6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, string> listEm = new SortedList<string, string> ();
            listEm.Add ("E01", "Tran Thi Thuy");
            listEm.Add ("E02", "Le Hai Ha");
            listEm.Add ("E03", "Nguyen Van Hung");
            listEm.Add ("E04", "Hoang Thi Thom");
            listEm.Add("E05", "Trinh Van Chien");
            Console.WriteLine ("Danh sach nhan vien");
            foreach(var key in listEm.Keys)
            {
                Console.WriteLine (key + ":" + listEm[key]);
            }
            Console.WriteLine("Danh sach nhan vien bat dau bang chu Th");
            foreach (var key in listEm.Keys)
            {
                if (listEm[key].StartsWith("th"))
                    Console.WriteLine(key+ ":" + listEm[key]);
            }
            //xoa nhan vien E04
            listEm.Remove("E04");
            //kiem tra neu chua co E06 thi them
            if (listEm.ContainsKey("E06"))
                listEm.Add("E06", "Nguyen Thi Linh");

            //in danh sach sau khi xoa, them
            foreach(var key in listEm.Keys)
            {
                Console.WriteLine(key + ":" + listEm[key]);
            }
        }
    }
}
