namespace tpmodul9_1302210095
{
    public class Mahasiswa
    {
        private String Nama { set; get; }
        private String Nim { set; get; }
        public Mahasiswa() { }
        public Mahasiswa(string nama, string nim)
        {
            Nama = nama;
            Nim = nim;
        }
    }
}
