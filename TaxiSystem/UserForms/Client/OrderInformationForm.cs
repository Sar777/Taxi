using System.Windows.Forms;
using TaxiSystem.Common;
using TaxiSystem.Networking;
using TaxiSystem.Protocol;

namespace TaxiSystem.UserForms.Client
{
    public partial class OrderInformationForm : Form
    {
        public static OrderInformationForm Form;
        private uint OrderID { get; set; }

        public OrderInformationForm(uint orderId)
        {
            InitializeComponent();
            Form = this;
            OrderID = orderId;
        }

        private void OrderInformationForm_Load(object sender, System.EventArgs e)
        {
            var packet = new Packet(Opcode.CMSG_GET_ORDER);
            packet.WriteUInt32(OrderID);
            TCPSocket.Instance.SendPacket(packet, true);
        }

        public void ParseInfo(Packet packet)
        {
            Text += packet.ReadUInt32();
            _lbTaxiType.Text += packet.ReadUTF8String();
            _lbStatus.Text += packet.ReadUTF8String();
            var unixtime = packet.ReadUInt32();
            _lbDateOrder.Text += Time.UnixTimeStampToDateTime(unixtime).ToString("HH:mm:ss yyyy-MM-dd");
            _lbAddressStart.Text += packet.ReadUTF8String();
            _lbAddressEnd.Text += packet.ReadUTF8String();
            _lbTaxiFor.Text += packet.ReadUTF8String(); // Owner name

            if (packet.ReadUInt8() == 1)
            {
                _lbDriverName.Text += packet.ReadUTF8String();
                _lbAutoMark.Text += packet.ReadUTF8String();
                _lbAutoColor.Text += packet.ReadUTF8String();
                _lbAutoNumber.Text += packet.ReadUTF8String();
                _lbTaxiType.Text += packet.ReadUTF8String();
                _lbRating.Text += "1";
            }
        }
    }
}
