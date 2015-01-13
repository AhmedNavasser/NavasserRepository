using System.Drawing;
using System.Windows.Forms;

namespace Client
{
    public partial class WelComeForm : Form
    {
        readonly string[] _colorCode = {"#ff0000","#ff0600","#ff0c00","#ff1200","#ff1800","#ff1e00","#ff2400","#ff2a00"
                                       ,"#ff3000","#ff3600","#ff3c00","#ff4200","#ff4800","#ff4e00","#ff5400","#ff5a00"
                                       ,"#FF6000","#ff6600","#FF6C00","#FF7200","#FF7800","#FF7E00","#FF8400","#FF8A00"
                                       ,"#FF9000","#FF9600","#FF9C00","#FFA200","#FFA800","#FFAE00","#FFB400","#FFBA00"
                                       ,"#FFC000","#FFC600","#FFCC00","#FFD200","#FFD800","#FFDE00","#FFE400","#FFEA00"
                                       ,"#FFF000","#FFF600","#FFFC00","#FCFF00","#f6ff00","#f0ff00","#eaff00","#e4ff00"
                                       ,"#deff00","#d8ff00","#d2ff00","#ccff00","#c6ff00","#c0ff00","#baff00","#b4ff00"
                                       ,"#aeff00","#a8ff00","#a2ff00","#9CFF00","#96FF00","#90FF00","#8AFF00","#84FF00"
                                       ,"#7EFF00","#78FF00","#72FF00","#6CFF00","#66FF00","#60FF00","#5AFF00","#54FF00"
                                       ,"#4EFF00","#48FF00","#42FF00","#3CFF00","#36FF00","#30FF00","#2AFF00","#24FF00"
                                       ,"#1EFF00","#18FF00","#12FF00","#0cff00","#06ff00","#00ff00","#00ff06","#00ff12"
                                       ,"#00ff18","#00FF1E","#00FF24","#00FF2A","#00FF30","#00FF36","#00FF3C","#00FF42"
                                       ,"#00FF48","#00FF4E","#00FF54","#00FF5A","#00FF60","#00FF66","#00FF6C","#00FF72"
                                       ,"#00FF78","#00FF7E","#00FF84","#00FF8A","#00FF90","#00FF96","#00FF9C","#00FFA2"
                                       ,"#00FFA8","#00FFAE","#00FFB4","#00FFBA","#00FFC0","#00FFC6","#00FFCC","#00FFD2"
                                       ,"#00FFD8","#00FFDE","#00FFE4","#00FFEA","#00FFF0","#00FFF6","#00FFFC","#00fffc"
                                       ,"#00FCFF","#00F6FF","#00F0FF","#00EAFF","#00E4FF","#00DEFF","#00D8FF","#00D2FF"
                                       ,"#00CCFF","#00C6FF","#00C0FF","#00BAFF","#00B4FF","#00AEFF","#00A8FF","#00A2FF"
                                       ,"#009CFF","#0096FF","#0090FF","#008AFF","#0084FF","#007EFF","#0078FF","#0072FF"
                                       ,"#006CFF","#0066FF","#0060FF","#005AFF","#0054FF","#004EFF","#0048FF","#0042FF"
                                       ,"#003CFF","#0036FF","#0030FF","#002AFF","#0024FF","#001EFF","#0018FF","#0012FF"
                                       ,"#000CFF","#0006FF","#0000FF","#0600FF","#0C00FF","#1200FF","#1800FF","#1E00FF"
                                       ,"#2400FF","#2A00FF","#3000FF","#3000FF","#3C00FF","#4200FF","#4800FF","#4E00FF"
                                       ,"#5400FF","#5A00FF","#6000FF","#6600FF","#6C00FF","#7200FF","#7800FF","#7E00FF"
                                       ,"#8400FF","#8A00FF","#9000FF","#9600FF","#9C00FF","#A200FF","#A800FF","#AE00FF"
                                       ,"#B400FF","#BA00FF","#C000FF","#C600FF","#CC00FF","#D200FF","#D800FF","#DE00FF"
                                       ,"#E400FF","#EA00FF","#F000FF","#F600FF","#FC00FF","#FF00FC","#FF00F0","#FF00E4"
                                       ,"#FF00D8","#FF00CC","#FF00C0","#FF00B4","#FF00A8","#FF009C","#FF0090","#FF0084"
                                       ,"#FF0078","#FF006C","#FF0060","#FF0054","#FF0048","#FF003C","#FF0030","#FF0024"
                                       ,"#FF0018","#FF000C","#FF0000"
                                       };
        int _colorIndex ;
        public WelComeForm()
        {
            InitializeComponent();
        }

      

        private void WelComeForm_Load(object sender, System.EventArgs e)
        {
            changeBackgroundColorTimer.Start();
        }

        private void nextButtonPictureBox_Click(object sender, System.EventArgs e)
        {
            Hide();
            var newUserForm = new NewUserForm();
            newUserForm.ShowDialog();
        }

        private void changeBackgroundColorTimer_Tick(object sender, System.EventArgs e)
        {
            BackColor = ColorTranslator.FromHtml(_colorCode[_colorIndex]);

            _colorIndex++;

            if (_colorIndex >= _colorCode.Length)
                _colorIndex = 0;
        }
    }
}
