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
	/// <summary>
	/// Конструктор формы.
	/// </summary>
	public ContactForm()
	{
		InitializeComponent();
	}

	/// <summary>
	/// Изменяет цвет картинки для добавления фотографии
	/// при наведении на нее курсора.
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void AddPhotoButton_MouseEnter(object sender, EventArgs e)
	{
		AddPhotoButton.Image = Properties.Resources.add_photo_32x32;
	}

	/// <summary>
	/// Изменяет цвет картинки для добавления фотографии
	/// при отведении от нее курсора.
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void AddPhotoButton_MouseLeave(object sender, EventArgs e)
	{
		AddPhotoButton.Image = Properties.Resources.add_photo_32x32_gray;
	}

	/// <summary>
	/// Закрывает форму.
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void CancelButton_Click(object sender, EventArgs e)
	{
		Close();
	}

	/// <summary>
	/// Запрещает вводить в поле для номера телефона все
	/// символы, кроме цифр и '-', '(', ')', ' ', '+'.
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
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
