using System.Windows.Forms;

namespace TechConnect
{
    public partial class UcUserRow : UserControl
    {
        private bool _selectedRow;

        public UcUserRow(UserDTO data)
        {
            InitializeComponent();

            SetData(data);
        }

        private void SetData(UserDTO data)
        {
            lblCode.Text = data.User;
            lblDescription.Text = data.Name;
            lblType.Text = data.Type.ToString();
            lblCEP.Text = data.CEP;
            lblMoreInforAddress.Text = data.AddressMoreInfo;
            lblPhoneNumber.Text = data.PhoneNumber;
            lblPhoneHouse.Text = data.HouseNumber.ToString();
            lblSexo.Text = data.Sexuality.ToString();
            picEnable.Image = data.Enable ? Image64.Base64ToImage(Image64.Ok) : Image64.Base64ToImage(Image64.Ng);
        }

        private void UcUser_Click(object sender, System.EventArgs e)
        {
            if (_selectedRow)
            {
                this.BorderStyle = BorderStyle.None;
                _selectedRow = false;
            }
            else
            {
                this.BorderStyle = BorderStyle.FixedSingle;
                _selectedRow = true;
            }
        }
    }
}
