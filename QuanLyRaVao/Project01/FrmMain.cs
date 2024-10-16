using Project01.Controls;
using Project01.FrmChild;
using Project01.Models;
using System;
using System.Drawing;
using System.Windows.Forms;
using static Project01.eNum.enumSW;

namespace Project01
{
  public partial class FrmMain : Form
  {
    private static Color Select = Color.MidnightBlue;
    private static Color NoSelect = Color.FromArgb(49, 67, 107);
    public FrmMain()
    {
      InitializeComponent();
      this.WindowState = FormWindowState.Maximized;
      this.StartPosition = FormStartPosition.CenterScreen;

      btnReport.Text = "";
      btnSetting.Text = "";
    }

    #region Singleton parttern
    private static FrmMain _Instance = null;
    public static FrmMain Instance
    {
      get
      {
        if (_Instance == null)
        {
          _Instance = new FrmMain();
        }
        return _Instance;
      }
    }
    #endregion


    #region Call form child
    private Form CurrentForm;
    public void OpenChildForm(AppModulSupport modulSupport, Form ChildForm)
    {
      bool Is_same_form = false;
      if (this.panelMain.Tag != null)
      {
        if (this.panelMain.Tag is Tuple<AppModulSupport, Form>)
        {
          Tuple<AppModulSupport, Form> TagAsForm = (Tuple<AppModulSupport, Form>)(this.panelMain.Tag);
          if (TagAsForm.Item1 == modulSupport)
          {
            Is_same_form = true;
          }
        }
      }
      if (Is_same_form == false)
      {
        if (CurrentForm != null)
        {
          CurrentForm.Visible = false;

        }
        this.panelMain.Tag = Tuple.Create(modulSupport, ChildForm);
        CurrentForm = ChildForm;
        ChildForm.TopLevel = false;
        ChildForm.FormBorderStyle = FormBorderStyle.None;
        ChildForm.Dock = DockStyle.Fill;
        ChildForm.BringToFront();
        this.panelMain.Controls.Add(ChildForm);
        ChildForm.Show();
      }
    }
    #endregion


    private void btnDashBoard_Click(object sender, EventArgs e)
    {
      ChangeButton(AppModulSupport.DashBoard);
    }

    private void btnMasterData_Click(object sender, EventArgs e)
    {
      ChangeButton(AppModulSupport.MasterData);
    }

    private void btnReport_Click(object sender, EventArgs e)
    {
      ChangeButton(AppModulSupport.Report);
    }

    private void btnSetting_Click(object sender, EventArgs e)
    {
      ChangeButton(AppModulSupport.Setting);
    }

    public void ChangeButton(AppModulSupport button)
    {
      this.btnDashBoard.ForeColor = NoSelect;
      this.btnMasterData.ForeColor = NoSelect;
      this.btnReport.ForeColor = NoSelect;
      this.btnSetting.ForeColor = NoSelect;

      switch (button)
      {
        case AppModulSupport.DashBoard:
          this.btnDashBoard.ForeColor = Select;
          OpenChildForm(AppModulSupport.DashBoard, FrmHome.Instance);
          break;
        case AppModulSupport.MasterData:
          this.btnMasterData.ForeColor = Select;
          OpenChildForm(AppModulSupport.MasterData, ManagerEmployeeFrm.Instance);
          break;
        case AppModulSupport.Report:
          this.btnReport.ForeColor = Select;
          OpenChildForm(AppModulSupport.Report, FrmReport.Instance);
          break;
        case AppModulSupport.Setting:
          this.btnSetting.ForeColor = Select;
          OpenChildForm(AppModulSupport.Setting, FrmSetting.Instance);
          break;
      }
    }

    private void FrmMain_Load(object sender, EventArgs e)
    {
      this.panelMenu.Width = 75;
      this.picLogo.Visible = false;
      this.picLogoVule.Visible = false;
      this.btnDashBoard.PerformClick();
    }



    private void btnMenu_Click(object sender, EventArgs e)
    {
      if (this.panelMenu.Width == 190)
      {
        this.panelMenu.Width = 75;
        this.picLogo.Visible = false;
        this.picLogoVule.Visible = false;

        btnReport.Text = "";
        btnSetting.Text = "";
      }
      else
      {
        this.panelMenu.Width = 190;
        this.picLogo.Visible = true;
        this.picLogoVule.Visible = true;

        btnReport.Text = "          DỮ LIỆU";
        btnSetting.Text = "          CÀI ĐẶT";
      }
    }

    private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      FrmHome.Instance.CheckCloseCamera();
      AppCore.Ins.CloseSerialDevice();
    }

    private void picUserAccount_Click(object sender, EventArgs e)
    {
      CallLogin();
    }

    private void lbUser_Click(object sender, EventArgs e)
    {
      if (lbUser.Text == "Đăng nhập")
      {
        CallLogin();
      }  
      else
      {
        var rs = MessageBox.Show("Bạn muốn đăng xuất ?");
        if (rs == DialogResult.OK)
        {
          AppCore.Ins._userCurrent = null;
          lbUser.Text = "Đăng nhập";
        }
      }  
    }

    private void CallLogin()
    {
      FrmLogIn frmLogIn = new FrmLogIn(AppCore.Ins._users);
      frmLogIn.OnSendLogInOK += FrmLogIn_OnSendLogInOK;
      frmLogIn.ShowDialog();
    }

    private void FrmLogIn_OnSendLogInOK(User user)
    {
      if (this.InvokeRequired)
      {
        this.Invoke(new Action(() =>
        {
          FrmLogIn_OnSendLogInOK(user);
        }));
        return;
      }

      lbUser.Text = user != null ? user.Name : "Đăng nhập";
      AppCore.Ins._userCurrent = user;
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

		private void lbPage_Click(object sender, EventArgs e)
		{

		}

		private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
		{

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
      UpdateUITimeRealTime();
		}

    private void UpdateUITimeRealTime()
    {
			if (this.InvokeRequired)
			{
				this.Invoke(new Action(() =>
				{
					UpdateUITimeRealTime();
				}));
				return;
			}

      lbDate.Text = DateTime.Now.ToString("dd / MM / yyyy");
			lbTime.Text = DateTime.Now.ToString("HH : mm : ss");
		}

		private void panelMain_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
