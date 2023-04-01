using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsApp.View;

public partial class ContactForm : Form
{
	public ContactForm()
	{
		InitializeComponent();
	}

	private void AddPhotoButton_MouseEnter(object sender, EventArgs e)
	{
		AddPhotoButton.Image = Properties.Resources.add_photo_32x32;
	}

	private void AddPhotoButton_MouseLeave(object sender, EventArgs e)
	{
		AddPhotoButton.Image = Properties.Resources.add_photo_32x32_gray;
	}

	private void CancelButton_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
	{
		if ((e.KeyChar >= '0')
			&& (e.KeyChar <= '9')
			|| (e.KeyChar == '-')
			|| (e.KeyChar == '(')
			|| (e.KeyChar == ')')
			|| (e.KeyChar == ' ')
			|| (e.KeyChar == (char)Keys.Back)
			|| (e.KeyChar == '+'))
		{
			return;
		}
		e.Handled = true;
	}
}
