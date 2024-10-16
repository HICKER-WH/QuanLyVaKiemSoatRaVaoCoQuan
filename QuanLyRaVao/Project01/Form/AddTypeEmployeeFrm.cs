using Project01.Controls;
using Project01.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using static Project01.eNum.enumSW;

namespace Project01.FrmChild
{
  public partial class AddTypeEmployeeFrm : Form
  {
    public delegate void SendReloadData();
    public event SendReloadData OnSendReloadData;

    private eTypeButton _eTypeButton;
    private TypeEmployee _typeEmployee;
    public AddTypeEmployeeFrm(eTypeButton eTypeButton, TypeEmployee typeEmployee)
    {
      InitializeComponent();
      _eTypeButton = eTypeButton;
      _typeEmployee = typeEmployee;

      btnAdd.Visible = eTypeButton == eTypeButton.Add;
      btnUpdate.Visible = eTypeButton == eTypeButton.Edit;
    }
    private void AddTypeEmployeeFrm_Load(object sender, EventArgs e)
    {
      if (_typeEmployee != null)
      {
        txtType.Text = _typeEmployee.NameType;
      }
    }
    private async void btnAdd_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(txtType.Text))
      {
        MessageBox.Show("Tên không được để trống !");
        return;
      }

      var exits = AppCore.Ins._typeEmployees.Any(x => x.NameType == txtType.Text);
      if (exits)
      {
        MessageBox.Show("Tên nhóm đã tồn tại. Vui lòng đặt tên khác !");
        return;
      }

      TypeEmployee typeEmployee = new TypeEmployee()
      {
        NameType = txtType.Text,
      };

      await AppCore.Ins.AddTypeEmployee(typeEmployee);
      OnSendReloadData?.Invoke();
      this.Close();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private async void btnUpdate_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(txtType.Text))
      {
        MessageBox.Show("Tên không được để trống !");
        return;
      }

      var exits = AppCore.Ins._typeEmployees.Any(x => x.NameType == txtType.Text);
      if (exits)
      {
        MessageBox.Show("Tên nhóm đã tồn tại. Vui lòng đặt tên khác !");
        return;
      }

      _typeEmployee.NameType = txtType.Text;
      _typeEmployee.UpdatedAt = DateTime.Now;

      await AppCore.Ins.UpdateTypeEmployee(_typeEmployee);
      OnSendReloadData?.Invoke();
      this.Close();
    }


  }
}
