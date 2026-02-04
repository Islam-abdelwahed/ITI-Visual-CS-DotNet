using lab_03.Enums;

namespace Lab_03.Models
{
    internal class NIC
    {
        private static NIC _instance;

        public string Manufacture { get; }
        public string MACAddress { get; }
        public NICType Type { get; }

        private NIC()
        {
            Manufacture = "Intel";
            MACAddress = "00-14-22-01-23-45";
            Type = NICType.Ethernet;
        }

        public static NIC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NIC();
                return _instance;
            }
        }

        public override string ToString()
        {
            return $"{Manufacture} | {MACAddress} | {Type}";
        }
    }
}
