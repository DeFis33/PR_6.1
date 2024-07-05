using System;
using System.Windows.Forms;

namespace PR6
{
    public partial class Project : Form
    {
        private ErrorProvider errorProvider;
        public Project()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
        }
        private void btnBook_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            DateTime fromDate = dateTimePicker1.Value;
            DateTime toDate = dateTimePicker2.Value;
            DateTime today = DateTime.Today;

            try
            {
                if (fromDate < today)
                {
                    errorProvider.SetError(dateTimePicker1, "Дата 'время бронирования с' не может быть в прошлом.");
                    return;
                }
                if (fromDate > toDate)
                {
                    errorProvider.SetError(dateTimePicker2, "Дата 'время бронирования с' не может быть позже 'время бронирования до'.");
                    return;
                }

                double totalCost = BookingManager.getInstance().CalculateTotalCost(fromDate, toDate, GetSelectedRoomRate());
                textBoxTotalCost.Text = totalCost.ToString("C0");

                DialogResult result = MessageBox.Show("Вы уверены, что хотите забронировать номер?", "Подтверждение бронирования", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Хорошего пребывания в Хостеле <<Топовая койка>>", "Спасибо!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClose_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private double GetSelectedRoomRate()
        {
            if (radioButtonRoom1.Checked) return 500;
            if (radioButtonRoom2.Checked) return 700;
            if (radioButtonRoom3.Checked) return 900;
            if (radioButtonLuxe1.Checked) return 1500;
            if (radioButtonLuxe2.Checked) return 2000;
            if (radioButtonLuxe3.Checked) return 2500;

            throw new Exception("Не выбран номер для бронирования.");
        }
        private void Book_Click(object sender, EventArgs e)
        {
            btnBook_Click(sender, e);
        }
        private void info_Click(object sender, EventArgs e)
        {
            Info form = new Info();
            form.Show();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void close_Click(object sender, EventArgs e)
        {
            btnClose_Click(sender, e);
        }
    }
}
